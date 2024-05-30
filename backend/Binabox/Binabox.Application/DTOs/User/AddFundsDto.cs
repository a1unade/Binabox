namespace Binabox.Application.DTOs.User;

public class AddFundsDto
{
    /// <summary>
    /// Id пользователя
    /// </summary>
    public string UserId { get; set; }
    
    /// <summary>
    /// Сумма пополнения
    /// </summary>
    public decimal Value { get; set; }
}