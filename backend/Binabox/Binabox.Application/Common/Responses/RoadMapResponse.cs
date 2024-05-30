namespace Binabox.Application.Common.Responses;

public class RoadMapResponse
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string Class { get; set; }
    
    public List<RoadMapListResponse> List { get; set; }
}