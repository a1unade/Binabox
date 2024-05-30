using Binabox.Domain.Entities;

namespace Binabox.Application.Common.Responses;

public class ReviewResponse: BaseResponse
{
    /// <summary>
    /// Id
    /// </summary>
    public int? Id { get; set; }
    
    /// <summary>
    /// Заголовок страницы
    /// </summary>
    public string? Title { get; set; }
    
    /// <summary>
    /// Подзаголовок страницы
    /// </summary>
    public string? Description { get; set; }

    public List<ReviewListResponse>? Reviews { get; set; }
}