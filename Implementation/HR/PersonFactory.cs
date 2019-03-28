using System;
using Practice.Common;

namespace Practice.HR
{
    /// <summary>
    /// Класс-фабрика, позволяющий получать экземпляры типов, инкапсулированных на уровне
    /// библиотеки.
    /// </summary>
    public sealed class PersonFactory
    {
        /// <summary>
        /// Возвращает экземпляр клиента.
        /// </summary>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="firstName">Имя.</param>
        /// <param name="fathersName">Отчество.</param>
        /// <param name="discount">Скидка.</param>
        /// <returns></returns>
        public IClient CreateClient(string lastName, string firstName, string fathersName, float discount)
        {
            /*
             * TODO #6 DONE Реализовать метод CreateClient класса PersonFactory
             */
            Name newClientName = new Name(firstName, fathersName, lastName);
            IClient newClient = new Client(newClientName, discount);
            return newClient;
        }

        /// <summary>
        /// Возвращает экземпляр сотрудника.
        /// </summary>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="firstName">Имя.</param>
        /// <param name="fathersName">Отчество.</param>
        /// <param name="department">Отдел, в котором работает сотрудник.</param>
        /// <returns></returns>
        public IEmployee CreateEmployee(string lastName, string firstName, string fathersName, string department)
        {
            /*
             * TODO #7 DONE Реализовать метод CreateeEmployee класса PersonFactory
             */
            Name newEmpName = new Name(firstName, fathersName, lastName);
            IEmployee newEmp = new Employee(newEmpName, new Organization.Department(department));
            return newEmp;
        }

    }
}
