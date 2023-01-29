using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Логическое И &&
            // x | y | x && y   true -> 1 false -> 0
            // 1 | 1 |   1
            // 1 | 0 |   0
            // 0 | 1 |   0
            // 0 | 0 |   0

            // Логическое ИЛИ ||
            // x | y | x || y   true -> 1 false -> 0
            // 1 | 1 |   1
            // 1 | 0 |   1
            // 0 | 1 |   1
            // 0 | 0 |   0

            int money = 400;
            int level = 1;

            if (money >= 500 || level > 9)
            {
                Console.WriteLine("Проходи! Добро пожаловать в нашу гильдию!");
            }
            else
            {
                Console.WriteLine("Вас выгнали за дверь!");
            }
        }
    }
}
