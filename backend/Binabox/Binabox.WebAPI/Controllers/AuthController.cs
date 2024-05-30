using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Auth;
using Binabox.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Binabox.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(IAuthService authService) : ControllerBase
{
    /// <summary>
    /// Регистрация пользователя 
    /// </summary>
    /// <param name="registerDto">Данные с формы регистрации</param>
    /// <returns></returns>
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        try
        {
            AuthResponse result = await authService.RegisterAsync(registerDto);
        
            if (result.ResponseType == ResponseTypes.Success)
                return Ok(result);
        
            return BadRequest(result.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Подтверждение почты пользователя
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <param name="token">Identity token для подтверждения почты</param>
    /// <returns>Результат при подтверждении пользователя error/success</returns>
    [HttpGet("confirmEmail")]
    public async Task<AuthResponse> ConfirmEmail(string userId, string token)
    {
        AuthResponse result = await authService.ConfirmEmailAsync(userId, token);

        if (result.ResponseType == ResponseTypes.Success)
        {
            // Добавление куки со значением ID пользователя
            Response.Cookies.Append("auth", userId, new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddDays(1),
                Path = "/"
            });
        }

        Response.Redirect($"http://localhost:5173/emailConfirmed/{userId}");

        return result;
    }
    
    /// <summary>
    /// Вход пользователя в аккаунт
    /// </summary>
    /// <param name="loginDto">Данные с формы при входе (email, password)</param>
    /// <returns>Результат выполнения success/error + message</returns>
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        try
        {
            AuthResponse result = await authService.LoginAsync(loginDto);
            string userId = await authService.GetUserIdByEmailAsync(loginDto.Email);

            if (result.ResponseType == ResponseTypes.Success && !String.IsNullOrEmpty(userId))
            {
                // Добавление куки со значением ID пользователя
                Response.Cookies.Append("auth", userId, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(1),
                    Path = "/"
                });
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Выход пользователя из аккаунта
    /// </summary>
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        try
        {
            Response.Cookies.Delete("auth");

            return Ok(new { Message = "пользователь вышел из аккаунта" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Удаление всех пользователей из бд
    /// </summary>
    /// <returns>Success/error</returns>
    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteAllUsers()
    {
        try
        {
            await authService.DeleteAllUsersAsync();

            return Ok(new { Message = "Пользователи были удалены" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}