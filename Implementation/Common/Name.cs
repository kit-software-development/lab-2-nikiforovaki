namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name: IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */
        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }       
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }       
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }
        /// <summary>
        ///    Полное имя.
        /// </summary>
        public string FullName { get; }
        /// <summary>
        ///   Фамилия+инциалы.
        /// </summary>
        public string ShortName { get; }
        public Name(string sur, string first, string patr)
        {
            FirstName = first;
            Surname = sur;
            Patronymic = patr;
            FullName = sur + ' ' + first + ' ' + patr;
            ShortName = sur + ' ' + first[0] + "." + patr[0] + '.';
        }
        public Name(IName name)
        {
            FullName = name.FullName;
            ShortName = name.ShortName;
            var arr = FullName.Split(' ');
            Surname = arr[0];
            FirstName = arr[1];           
            Patronymic = arr[2];
        }        
    }
}
