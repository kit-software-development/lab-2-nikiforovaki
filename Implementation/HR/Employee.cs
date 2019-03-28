using System;
using Practice.Common;
using Practice.HR.Events;
using Practice.Organization;


namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */
         private IDepartment department1;

        public IDepartment Department
        {
            get{return department1;}
            set
            {
                ValueChangeEventArgs<IDepartment> args = new ValueChangeEventArgs<IDepartment>(department1);
                department1 = value;
                DepartmentChange?.Invoke(this, args);
            }
        }

        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
