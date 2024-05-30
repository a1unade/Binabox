using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class UserFeedback: BaseEntity
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Эл. почта
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Сообщение
    /// </summary>
    public string Message { get; set; }
}