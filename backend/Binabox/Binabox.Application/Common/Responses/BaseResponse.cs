using Binabox.Application.Common.Enums;

namespace Binabox.Application.Common.Responses;

public class BaseResponse
{
    /// <summary>
    /// Тип ответа
    /// </summary>
    public ResponseTypes ResponseType { get; set; }
    
    public List<string>? Errors { get; set; }
}