using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Transaction: BaseEntity
{
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Дата
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Внешний ключ
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи
    /// </summary>
    public User User { get; set; }
}