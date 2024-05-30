namespace Binabox.Application.Common.Responses;

public class TransactionResponse
{
    /// <summary>
    /// Id транзакции
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название транзакции
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Дата транзакции
    /// </summary>
    public string Date { get; set; }
}