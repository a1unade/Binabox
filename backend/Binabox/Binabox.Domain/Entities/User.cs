using Microsoft.AspNetCore.Identity;

namespace Binabox.Domain.Entities;

public class User : IdentityUser<Guid>
{
    /// <summary>
    /// Информация о пользователе пользователя
    /// </summary>
    public UserInfo UserInfo { get; set; }
    
    /// <summary>
    /// Транзакции пользователя
    /// </summary>
    public ICollection<Transaction> Transactions { get; set; }
}