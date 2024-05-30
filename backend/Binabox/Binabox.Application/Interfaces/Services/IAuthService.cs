using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Auth;

namespace Binabox.Application.Interfaces.Services;

public interface IAuthService
{
    /// <summary>
    /// Регистрация пользователя
    /// </summary>
    /// <returns>Результат выполнения success/error + message</returns>
    Task<AuthResponse> RegisterAsync(RegisterDto registerDto);
    
    /// <summary>
    /// Подтверждение почты
    /// </summary>
    /// <returns>Результат выполнения success/error + message</returns>
    Task<AuthResponse> ConfirmEmailAsync(string userId, string token);

    /// <summary>
    /// Вход пользователя в аккаунт
    /// </summary>
    /// <param name="loginDto">Данные с формы (адрес электронной почты и пароль)</param>
    /// <returns>Результат выполнения success/error + message</returns>
    Task<AuthResponse> LoginAsync(LoginDto loginDto);

    /// <summary>
    /// Получение ID пользователя для куки по адресу электронной почты
    /// </summary>
    /// <param name="email">Адрес электронной почты</param>
    /// <returns>ID пользователя</returns>
    Task<string> GetUserIdByEmailAsync(string email);

    /// <summary>
    /// Удаление пользователей из бд (для проверки функционала)
    /// </summary>
    Task DeleteAllUsersAsync();
}
