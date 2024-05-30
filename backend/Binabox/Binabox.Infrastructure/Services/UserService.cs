using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Shop;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Application.Interfaces.Services;
using Binabox.Domain.Common.Enums;
using Binabox.Domain.Entities;

namespace Binabox.Infrastructure.Services;

public class UserService(IUserRepository userRepository): IUserService
{
    public async Task<UserResponse> GetUserByEmailAsync(string email)
    {
        try
        {
            User user =  await userRepository.GetUserByEmailAsync(email);
            
            return new UserResponse
            {
                ResponseType = ResponseTypes.Success,
                Email = user.Email!,
                Nickname = user.UserInfo.Nickname,
                Subscription = user.UserInfo.Subscription,
                Type = user.UserInfo.Type,
                Avatar = user.UserInfo.Avatar,
                Balance = user.UserInfo.Balance
            };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/GetUserByEmail: " + ex.Message);
            Console.ResetColor();
            
            return new UserResponse { ResponseType = ResponseTypes.Error };
        }
    }

    public async Task<UserResponse> GetUserByIdAsync(string id)
    {
        try
        {
            User user = await userRepository.GetUserByIdAsync(id);
            
            return new UserResponse
            {
                ResponseType = ResponseTypes.Success,
                Email = user.Email!,
                Nickname = user.UserInfo.Nickname,
                Subscription = user.UserInfo.Subscription,
                Type = user.UserInfo.Type,
                Avatar = user.UserInfo.Avatar,
                Balance = user.UserInfo.Balance
            };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/GetUserById: " + ex.Message);
            Console.ResetColor();
            
            return new UserResponse { ResponseType = ResponseTypes.Error };
        }
    }

    public async Task<BaseResponse> ChangeUserNicknameAsync(string nickname, string userId)
    {
        try
        {
            await userRepository.ChangeUserNicknameAsync(nickname, userId);

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/ChangeUserNicknameAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }

    public async Task<BaseResponse> ChangeUserAvatarAsync(string avatar, string userId)
    {
        try
        {
            await userRepository.ChangeUserAvatarAsync(avatar, userId);

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/ChangeUserAvatarAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }

    public async Task<BaseResponse> AddFundsToBalanceAsync(string userId, decimal value)
    {
        try
        {
            if (value <= 0)
                return new BaseResponse
                {
                    ResponseType = ResponseTypes.Error,
                    Errors = new List<string> { "Сумма пополнения должна быть больше 0!" }
                };
            
            await userRepository.AddFundsToBalanceAsync(userId, value);
            
            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/AddFundsToBalanceAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }

    public async Task<BaseResponse> RemoveFundsFromBalanceAsync(string userId, decimal value)
    {
        try
        {
            if (value <= 0)
                return new BaseResponse
                {
                    ResponseType = ResponseTypes.Error,
                    Errors = new List<string> { "Сумма списания должна быть больше 0!" }
                };
            
            await userRepository.RemoveFundsFromBalanceAsync(userId, value);
            
            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/RemoveFundsFromBalanceAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }

    public async Task<TransactionResponse[]> GetUserTransactionsAsync(string userId)
    {
        try
        {
            var transactions = await userRepository.GetUserTransactionsAsync(userId);
            List<TransactionResponse> transactionResponse = new List<TransactionResponse>();

            if (transactions.Length == 0)
                return [];

            foreach (var tr in transactions)
            {
               transactionResponse.Add(new TransactionResponse
               {
                   Id = tr.Id,
                   Name = tr.Name,
                   Date = tr.Date.ToString("D")
               }); 
            }

            return transactionResponse.ToArray();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/GetUserTransactionsAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }
    
    public async Task<BaseResponse> BuySubscriptionAsync(string userId, decimal price, SubscriptionType subscriptionType)
    {
        try
        {
            return await userRepository.BuySubscriptionAsync(userId, price, subscriptionType);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/BuySubscriptionAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }
}