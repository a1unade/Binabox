using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class SubscriptionProperty: BaseEntity
{
    /// <summary>
    /// Описание привилегии
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Внешний ключ
    /// </summary>
    public int SubscriptionId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public Subscription Subscription { get; set; }
}