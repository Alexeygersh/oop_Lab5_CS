using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop_Lab5_GershA_c_
{
    internal class Program
    {
        static void Main()
        {
            var container = new PlayerContainer();
            int choice;

            do
            {
                Console.WriteLine("Система шахматного турнира");
                Console.WriteLine("1. Добавить игрока");
                Console.WriteLine("2. Добавить онлайн-игрока");
                Console.WriteLine("3. Вывести всех игроков");
                Console.WriteLine("4. Загрузить игроков из файла");
                Console.WriteLine("5. Сохранить игроков в файл");
                Console.WriteLine("6. Очистить всех игроков");
                Console.WriteLine("0. Выход");
                Console.Write("Введите ваш выбор: ");

                choice = int.Parse(Console.ReadLine() ?? "0");

                switch (choice)
                {
                    case 1:
                        container.AddPlayer();
                        break;
                    case 2:
                        container.AddOnlinePlayer();
                        break;
                    case 3:
                        container.DisplayPlayers();
                        break;
                    case 4:
                        Console.Write("Введите имя файла: ");
                        var loadFilename = Console.ReadLine();
                        container.LoadFromFile(loadFilename);
                        break;
                    case 5:
                        Console.Write("Введите имя файла: ");
                        var saveFilename = Console.ReadLine();
                        container.SaveToFile(saveFilename);
                        break;
                    case 6:
                        container.ClearPlayers();
                        break;
                    case 0:
                        Console.WriteLine("Выход...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
