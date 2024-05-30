namespace Binabox.Application.Common.Responses;

public class CategoryResponse: BaseResponse
{
    /// <summary>
    /// Id категории
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название категории
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Информация о предмете в представленной категории
    /// </summary>
    public string Info { get; set; }
}