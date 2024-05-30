using Binabox.Domain.Common.Enums;

namespace Binabox.Application.Common.Responses;

public class UserResponse: BaseResponse
{
    /// <summary>
    /// Никнейм пользователя
    /// </summary>
    public string? Nickname { get; set; }
    
    /// <summary>
    /// Электронная почта пользователя
    /// </summary>
    public string? Email { get; set; }
    
    /// <summary>
    /// Тип пользователя
    /// </summary>
    public UserType? Type { get; set; }
    
    /// <summary>
    /// Аватарка пользователя
    /// </summary>
    public string Avatar { get; set; }
    
    /// <summary>
    /// Баланс кошелька
    /// </summary>
    public decimal Balance { get; set; }
    
    /// <summary>
    /// Тип подписки пользователя
    /// </summary>
    public SubscriptionType? Subscription { get; set; }
}