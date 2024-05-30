using Binabox.Domain.Common.Enums;

namespace Binabox.Application.DTOs.User;

public class BuySubscriptionDto
{
    /// <summary>
    /// ID пользователя
    /// </summary>
    public string UserId { get; set; }
    
    /// <summary>
    /// Цена подписки
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Тип подписки
    /// </summary>
    public SubscriptionType SubscriptionType { get; set; }
}