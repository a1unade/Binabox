using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class AboutStat: BaseEntity
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
    /// Описание
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Внешний ключ для About
    /// </summary>
    public int AboutId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для About
    /// </summary>
    public About About { get; set; }
}