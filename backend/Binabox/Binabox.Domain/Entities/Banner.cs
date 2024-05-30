using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Banner: BaseEntity
{
    /// <summary>
    /// Язык для локализации
    /// </summary>
    public string Language {get; set;}
    
    /// <summary>
    /// Заголовок баннера
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Описание к заголовку
    /// </summary>
    public string Description { get; set; }
}