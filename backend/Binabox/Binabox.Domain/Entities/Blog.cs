using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Blog: BaseEntity
{
    /// <summary>
    /// Превью статьи
    /// </summary>
    public string Image { get; set; }
    
    public string Category { get; set; }
    
    /// <summary>
    /// Заголовок статьи
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Автор статьи
    /// </summary>
    public string User { get; set; }
    
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateOnly Date { get; set; }
    
    /// <summary>
    /// Краткое описание
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public BlogDetails BlogDetails { get; set; }
}