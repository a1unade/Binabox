namespace Binabox.Application.Common.Responses;

public class ItemResponse: BaseResponse
{
    /// <summary>
    /// ID товара
    /// </summary>
    public int? Id { get; set; }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string? Title { get; set; }
    
    /// <summary>
    /// Картинка товара
    /// </summary>
    public string? Image { get; set; }
    
    /// <summary>
    /// Описание товара
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Информация о товаре в различных категориях
    /// </summary>
    public List<CategoryResponse>? Categories { get; set; }
    
    /// <summary>
    /// Похожие товары
    /// </summary>
    public List<ShopResponse>? Suggestions { get; set; }
    
    /// <summary>
    /// Цена товара
    /// </summary>
    public decimal? Price { get; set; }
}