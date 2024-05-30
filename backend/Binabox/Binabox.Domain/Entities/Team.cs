using Binabox.Domain.Common;

namespace Binabox.Domain.Entities;

public class Team: BaseEntity
{
    public string Language { get; set; }
    
    /// <summary>
    /// Картинка сотрудника
    /// </summary>
    public string Image { get; set; }
    
    /// <summary>
    /// Имя сотрудника
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Должность сотрудника
    /// </summary>
    public string Position { get; set; }
}