namespace Binabox.Application.Common.Responses;

public class SubscriptionResponse
{
    /// <summary>
    /// Id подписки
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название подписки
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Картинка подписки
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Цена подписки
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Привилегии подписки
    /// </summary>
    public List<SubsriptionPropertyResponse> Properties { get; set; }
}