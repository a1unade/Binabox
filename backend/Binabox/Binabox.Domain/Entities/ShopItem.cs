using Binabox.Domain.Common.Interfaces;

namespace Binabox.Domain.Entities;

public class ShopItem: IEntity
{
    public int Id { get; set; }
    
    /// <summary>
    /// Картинка товара
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Свойство для связи
    /// </summary>
    public ItemDetail ItemDetail { get; set; }
}