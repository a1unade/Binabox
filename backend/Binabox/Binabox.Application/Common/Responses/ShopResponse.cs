namespace Binabox.Application.Common.Responses;

public class ShopResponse
{
    /// <summary>
    /// ID товара
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Картинка товара
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string Title { get; set; }
}