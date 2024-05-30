using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Contact: BaseEntity
{
    /// <summary>
    /// Язык локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Картинка
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Контактная информация 
    /// </summary>
    public string Info { get; set; }
}