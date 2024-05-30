using Binabox.Domain.Common.Interfaces;

namespace Binabox.Domain.Entities;

public class ItemDetail: IEntity
{
    public int Id { get; set; }
    
    /// <summary>
    /// ID предмета
    /// </summary>
    public int ItemId { get; set; }
    
    /// <summary>
    /// Описание товара
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Цена товара
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Информация о товаре в разных категориях
    /// </summary>
    public List<ItemCategory> ItemCategories { get; set; }
    
    /// <summary>
    /// Свойство для связи
    /// </summary>
    public ShopItem ShopItem { get; set; }
}