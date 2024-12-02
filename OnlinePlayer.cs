using oop_Lab5_GershA_c_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop_Lab5_GershA_c_
{
    [Serializable]
    public class OnlinePlayer : Player
    {
        public string VirtualName { get; set; } = "unknown";
        public string Email { get; set; } = "unknown@gmail.com";
        public ulong Tel { get; set; }

        public override void ReadFromConsole()
        {
            base.ReadFromConsole();

            Console.Write("Введите ник: ");
            VirtualName = Console.ReadLine();

            Console.Write("Введите адрес почты: ");
            Email = Console.ReadLine();

            Console.Write("Введите номер телефона в виде 9991010010: (+7)");
            Tel = InputUtils.InputNum<ulong>(1000000000, 9999999999);
        }

        public override void DisplayToConsole()
        {
            base.DisplayToConsole();
            Console.WriteLine($"Ник: {VirtualName}, Почта: {Email}, Телефон: +7{Tel}");
        }
    }
}


