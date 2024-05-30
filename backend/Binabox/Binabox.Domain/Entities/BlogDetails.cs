using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class BlogDetails: BaseEntity
{
    public int ContentId { get; set; }
    public BlogContent BlogContent { get; set; }
}