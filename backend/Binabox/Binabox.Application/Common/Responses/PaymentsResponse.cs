namespace Binabox.Application.Common.Responses;

public class PaymentsResponse: BaseResponse
{
    /// <summary>
    /// Заголовок страницы
    /// </summary>
    public string? Title { get; set; }
    
    /// <summary>
    /// Подзаголовок страницы
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Подписки
    /// </summary>
    public List<SubscriptionResponse>? Subscriptions { get; set; }
}