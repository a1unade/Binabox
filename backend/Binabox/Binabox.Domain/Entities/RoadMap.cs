using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class RoadMap: BaseEntity
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
    /// Класс (слева или справа находится блок)
    /// </summary>
    public string Class { get; set; }
    
    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public ICollection<RoadMapBenefit> RoadMapBenefits { get; set; }
}