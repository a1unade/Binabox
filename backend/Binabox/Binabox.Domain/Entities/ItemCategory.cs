using Binabox.Domain.Common.Interfaces;

namespace Binabox.Domain.Entities;

public class ItemCategory: IEntity
{
    public int Id { get; set; }
    
    public int ItemDetailId { get; set; }
    
    /// <summary>
    /// Имя категории
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Информация о товаре
    /// </summary>
    public string Info { get; set; }
    
    /// <summary>
    /// Свойство для связи
    /// </summary>
    public ItemDetail ItemDetail { get; set; }
}