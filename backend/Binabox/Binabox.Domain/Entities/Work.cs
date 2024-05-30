using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Work: BaseEntity
{
    /// <summary>
    /// Язык для локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Кратинка блока
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Заголовок блока
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Текст блока
    /// </summary>
    public string Text { get; set; }
}