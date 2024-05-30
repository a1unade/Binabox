using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class AboutCounter: BaseEntity
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
    /// Стата
    /// </summary>
    public int Number { get; set; }
    
    /// <summary>
    /// Внешний ключ для About
    /// </summary>
    public int AboutId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для About
    /// </summary>
    public About About { get; set; }
}