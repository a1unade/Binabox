namespace Binabox.Application.DTOs.Shop;

public class AddItemDto
{
    /// <summary>
    /// Картинка товара
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Описание товара
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Цена товара
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Категории товаров
    /// </summary>
    public string Face { get; set; }
    public string Clothing { get; set; }
    public string Eyes { get; set; }
    public string Skin { get; set; }
    public string Background { get; set; }
    public string Special { get; set; }
}