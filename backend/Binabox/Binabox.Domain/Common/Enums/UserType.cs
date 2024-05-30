namespace Binabox.Domain.Common.Enums;

/// <summary>
/// Типы пользователей
/// </summary>
public enum UserType {
    /// <summary>
    /// Пользователь, который не вошел в аккаунт
    /// </summary>
    Undefined,
    
    /// <summary>
    /// Пользователь, который вошел в аккаунт
    /// </summary>
    User,
    
    /// <summary>
    /// Администратор сайта
    /// </summary>
    Admin
}