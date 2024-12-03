using System;
using System.Xml.Serialization;


namespace oop_Lab5_GershA_c_
{
    [Serializable]
    [XmlInclude(typeof(OnlinePlayer))]
    public class Player
    {
        public string Name { get; set; } = "Неизвестно";
        public int Age { get; set; }
        public int Rating { get; set; }
        public string Gender { get; set; } = "Мужской";
        public string RegistrationDate { get; set; } = "01-09-2024";
        public bool IsActive { get; set; } = true;

        public virtual void ReadFromConsole()
        {
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();

            Console.Write("Введите возраст (0-120): ");
            Age = InputUtils.InputNum(0, 120);

            Console.Write("Введите рейтинг (0-3000): ");
            Rating = InputUtils.InputNum(0, 3000);

            Console.Write("Введите пол | '0' для Мужского или '1' для Женского: ");
            int genderInput = InputUtils.InputNum(0, 1);
            Gender = genderInput == 0 ? "Мужской" : "Женский";

            Console.Write("Введите дату регистрации (DD-MM-YYYY): ");
            RegistrationDate = Console.ReadLine();

            Console.Write("Игрок активен в данный момент? (1 - да, 0 - нет): ");
            IsActive = InputUtils.InputNum(0, 1) == 1;
        }

        public virtual void DisplayToConsole()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Рейтинг: {Rating}, Пол: {Gender}, Дата регистрации: {RegistrationDate}, Активен: {(IsActive ? "Да" : "Нет")}");
        }
    }
}

