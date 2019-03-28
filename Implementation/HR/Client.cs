using Practice.Common;
using Practice.HR.Events;
using System;


namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        /*
         * TODO #4: Реализуйте интерфейс IClient для класса Client
         */
         private float discount1;

        public float Discount
        {
            get{return discount1;}
            set
            {
                var args = new ValueChangeEventArgs<float>(discount1);
                discount1 = value;
                DiscountChange?.Invoke(this, args);
            }
        }
        public event EventHandler<ValueChangeEventArgs<float>> DiscountChange;
    }

}
