namespace Binabox.Application.Common.Responses;

public class ReviewListResponse
{
    /// <summary>
    /// ID отзыва
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Отзыв
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Имя автора
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Аватарка автора
    /// </summary>
    public string Avatar { get; set; }
}