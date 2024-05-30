namespace Binabox.Application.DTOs.Auth;

/// <summary>
/// DTO для входа в аккаунт
/// </summary>
public class LoginDto
{
    /// <summary>
    /// Почта пользователя
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Пароль пользователя
    /// </summary>
    public string Password { get; set; }
}