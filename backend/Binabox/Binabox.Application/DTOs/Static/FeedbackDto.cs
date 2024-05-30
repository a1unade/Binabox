namespace Binabox.Application.DTOs.Static;

public class FeedbackDto
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