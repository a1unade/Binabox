using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Subscription: BaseEntity
{
    /// <summary>
    /// Язык локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Картинка подписки
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Название подписки
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Цена подписки
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Внешний ключ
    /// </summary>
    public int PaymentId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public Payment Payment { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public ICollection<SubscriptionProperty> SubscriptionProperties { get; set; }
}