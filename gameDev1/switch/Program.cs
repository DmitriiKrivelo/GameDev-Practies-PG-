using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek;
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "понедельник":
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("Идем в кино!");
                    Console.WriteLine("Едим попкорн!");
                    break;
                case "вторник":
                    Console.WriteLine("Проходим курсы!");
                    break;
                case "среда":
                    Console.WriteLine("Изучаем switch");
                    break;
                case "четверг":
                    Console.WriteLine("Проектируем приложение");
                    break;
                case "пятница":
                    Console.WriteLine("Полнейший чилл");
                    break;
                default:
                    Console.WriteLine("Я такого дня не знаю");
                    break;
            }
        }
    }
}
