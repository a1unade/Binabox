using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Faq: BaseEntity
{
    /// <summary>
    /// Язык локализации
    /// </summary>
    public string Language { get; set; }
    
    /// <summary>
    /// Вопрос
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Ответ на вопрос
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Раскрыт ли блок вопроса
    /// </summary>
    public bool Show { get; set; }
}