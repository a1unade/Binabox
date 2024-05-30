using Binabox.Domain.Entities;

namespace Binabox.Application.Common.Responses;

public class AboutResponse: BaseResponse
{
    public string? Title { get; set; }
    
    public string? Description { get; set; }
    
    public List<AboutCounter>? AboutCounters { get; set; }
    
    public List<AboutStat>? AboutStats { get; set; }
}