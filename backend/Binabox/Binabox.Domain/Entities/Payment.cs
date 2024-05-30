using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Payment: BaseEntity
{
    /// <summary>
    /// Язык локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Подзаголовок
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public ICollection<Subscription> Subscriptions { get; set; }
}