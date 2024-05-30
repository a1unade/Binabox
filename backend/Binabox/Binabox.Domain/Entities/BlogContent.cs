using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class BlogContent: BaseEntity
{
    /// <summary>
    /// Части статьи
    /// </summary>
    public string P1 { get; set; }
    public string P2 { get; set; }
    public string P3 { get; set; }
    public string P4 { get; set; }
    public string P5 { get; set; }
    
    /// <summary>
    /// Подзаголовки статьи
    /// </summary>
    public string Title1 { get; set; }
    public string Title2 { get; set; }
    public string Title3 { get; set; }

    // public int PostId { get; set; }
    // public Post Post { get; set; }
    
    public int ImagesId { get; set; }
    public BlogImages BlogImages { get; set; }
}