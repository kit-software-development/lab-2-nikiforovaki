using Practice.Common;
using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson: IPerson
    {
         private IName name1;

        public IName Name
        {
            get{return name1;}
            set
            {
                var args = new ValueChangeEventArgs<IName>(name1);
                name1 = value;
                NameChange?.Invoke(this, args);
            }
        }
        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;
     /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */
    }
}
