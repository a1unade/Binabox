namespace Binabox.Application.DTOs.Shop;

public class BuyDto
{
    /// <summary>
    /// ID товара
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Почта для отправки товара
    /// </summary>
    public string UserEmail { get; set; }
}