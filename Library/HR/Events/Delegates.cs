using Practice.Common;
using Practice.Organization;

namespace Practice.HR.Events
{
    /// <summary>
    /// Делегат события изменения имени человека.
    /// </summary>
    /// <param name="sender">Источник события. Как правило, человек у которого изменилось имя.</param>
    /// <param name="e">Аргументы события.</param>
    public delegate void NameChangeEventHandler(object sender, ValueChangeEventArgs<IName> e);
    
    /// <summary>
    /// Делегат события изменения отдела, в котором работает человек.
    /// </summary>
    /// <param name="sender">Источник события. Как правило, человек, которому выдали новый паспорт.</param>
    /// <param name="e">Аргументы собития.</param>
    public delegate void DepartmentChangeEventHandler(object sender, ValueChangeEventArgs<IDepartment> e);
}
