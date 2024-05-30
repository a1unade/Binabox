using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Review: BaseEntity
{
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
    
    /// <summary>
    /// Внешний ключ для связи
    /// </summary>
    public int ReviewInfoId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public ReviewInfo ReviewInfo { get; set; }
}