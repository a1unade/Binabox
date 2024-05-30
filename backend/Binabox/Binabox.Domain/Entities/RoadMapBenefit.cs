using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class RoadMapBenefit: BaseEntity
{
    /// <summary>
    /// Описание улучшения
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Внешний ключ
    /// </summary>
    public int RoadMapId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public RoadMap RoadMap { get; set; }
}