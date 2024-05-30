namespace Binabox.Application.DTOs.Static;

public class ReviewDto
{
    /// <summary>
    /// Никнейм автора
    /// </summary>
    public string Nickname { get; set; }
    
    /// <summary>
    /// Аватарка автора
    /// </summary>
    public string Avatar { get; set; }
    
    /// <summary>
    /// Язык локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Отзыв пользователя
    /// </summary>
    public string Text { get; set; }
}