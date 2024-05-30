using System.Net;
using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Messages.Error;
using Binabox.Application.Common.Messages.Success;
using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Auth;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Application.Interfaces.Services;
using Binabox.Domain.Entities;
using Binabox.Infrastructure.SignalR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Binabox.Domain.Common.Enums;

namespace Binabox.Infrastructure.Services;

public class AuthService(IUserRepository userRepository, IEmailService emailSender, IHubContext<EmailConfirmationHub> hubContext) : IAuthService
{
    public async Task<AuthResponse> RegisterAsync(RegisterDto registerDto)
    {
        try
        {
            UserInfo userInfo = new UserInfo
            {
                Nickname = registerDto.Nickname,
                Type = UserType.User,
                Subscription = SubscriptionType.Free,
                Balance = 0,
                Avatar = "http://localhost:5112/static/avatars/users-1.svg" // Дефолтная аватарка пользователя
            };

            User user = new User
            {
                UserName = registerDto.Email,
                Email = registerDto.Email,
                UserInfo = userInfo
            };
            
            IdentityResult result = await userRepository.CreateUserAsync(user, registerDto.Password);
            
            if (result.Succeeded)
            {
                string token = await userRepository.GenerateConfirmationTokenAsync(user);
                string confirmationLink =
                    $"http://localhost:5112/api/Auth/confirmEmail?userId={user.Id}&token={WebUtility.UrlEncode(token)}";
            
                await emailSender.SendEmailAsync(user.Email, "Подтверждение почты", 
                    emailSender.GenerateEmailConfirmationMessage(confirmationLink));

                return new AuthResponse { ResponseType = ResponseTypes.Success, Message = AuthSuccessMessages.RegisterSuccess };
            }
            
            return new AuthResponse { ResponseType = ResponseTypes.Error, Message = AuthErrorMessages.RegisterError };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AuthService/Register: " + ex.Message);
            Console.ResetColor();
            
            return new AuthResponse { ResponseType = ResponseTypes.Error, Message = AuthErrorMessages.RegisterError };
        }
    }

    public async Task<AuthResponse> ConfirmEmailAsync(string userId, string token)
    {
        try
        {
            User user = await userRepository.FindUserByIdAsync(userId);
            IdentityResult result = await userRepository.ConfirmUserEmailAsync(user, token);
            
            if (result.Succeeded)
            {
                await hubContext.Clients.All.SendAsync("ReceiveEmailConfirmationStatus", true);
            
                return new AuthResponse { ResponseType = ResponseTypes.Success, Message = AuthSuccessMessages.EmailConfirmed };
            }
        
            return new AuthResponse { ResponseType = ResponseTypes.Error, Message = AuthErrorMessages.EmailConfirmationError };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AuthService/ConfirmEmail: " + ex.Message);
            Console.ResetColor();
            
            return new AuthResponse { ResponseType = ResponseTypes.Error, Message = AuthErrorMessages.UserNotFound };
        }
    }

    public async Task<AuthResponse> LoginAsync(LoginDto loginDto)
    {
        try
        {
            User user = await userRepository.FindUserByEmailAsync(loginDto.Email);

            bool isPasswordCorrect = await userRepository.CheckPasswordAsync(user, loginDto.Password);

            if (isPasswordCorrect)
                return new AuthResponse
                    { ResponseType = ResponseTypes.Success, Message = AuthSuccessMessages.LoginSuccess };

            return new AuthResponse { ResponseType = ResponseTypes.Error, Message = AuthErrorMessages.LoginWrongPassword };
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AuthService/Login: " + ex.Message);
            Console.ResetColor();
            
            return new AuthResponse { ResponseType = ResponseTypes.Error, Message = AuthErrorMessages.UserNotFound };
        }
    }

    public async Task<string> GetUserIdByEmailAsync(string email)
    {
        try
        {
            User user = await userRepository.FindUserByEmailAsync(email);

            return user.Id.ToString();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AuthService/GetUserIdByEmail: " + ex.Message);
            Console.ResetColor();
            
            return String.Empty;
        }
    } 
    
    public async Task DeleteAllUsersAsync()
    {
        List<User> users = await userRepository.GetUsersListAsync();

        foreach (var user in users)
            await userRepository.DeleteUserAsync(user);
    }
}