using Binabox.Domain.Common;
using Binabox.Domain.Common.Enums;

namespace Binabox.Domain.Entities;

public class UserInfo : BaseEntity
{
    /// <summary>
    /// ID пользователя
    /// </summary>
    public Guid UserId { get; set; }
        
    /// <summary>
    /// Ник пользователя
    /// </summary>
    public string Nickname { get; set; }
    
    /// <summary>
    /// Тип пользователя
    /// </summary>
    public UserType Type { get; set; }
    
    /// <summary>
    /// Тип подписки пользователя
    /// </summary>
    public SubscriptionType Subscription { get; set; }
    
    /// <summary>
    /// Аватарка пользователя
    /// </summary>
    public string Avatar { get; set; }
    
    /// <summary>
    /// Баланс пользователя
    /// </summary>
    public decimal Balance { get; set; }

    /// <summary>
    /// Навигационное свойство для связи с User
    /// </summary>
    public User User { get; set; }
}