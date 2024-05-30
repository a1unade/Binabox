using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class ReviewInfo: BaseEntity
{
    /// <summary>
    /// Язык локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Заголовок страницы
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Подзаголовок страницы
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public ICollection<Review> Reviews { get; set; }
}