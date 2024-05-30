using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class About: BaseEntity
{
    /// <summary>
    /// Язык для локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Загловок
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Коллекция счетчиков
    /// </summary>
    public ICollection<AboutCounter> AboutCounters { get; set; }
    
    /// <summary>
    /// Коллекция статистик
    /// </summary>
    public ICollection<AboutStat> AboutStats { get; set; }
}