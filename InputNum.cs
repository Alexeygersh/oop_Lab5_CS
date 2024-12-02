using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Lab5_GershA_c_
{
    public static class InputUtils
    {
        public static T InputNum<T>(T min, T max) where T : IComparable
        {
            T value;
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    value = (T)Convert.ChangeType(input, typeof(T));
                    if (value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Значение должно быть в диапазоне от {min} до {max}. Повторите ввод:");
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод. Повторите снова:");
                }
            }
            return value;
        }
    }
}

