using Binabox.Domain.Common;
namespace Binabox.Domain.Entities;

/// <summary>
/// Аватарка пользователя
/// </summary>
public class Avatar: BaseEntity
{
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// URL картинки
    /// </summary>
    public string Url { get; set; }
}