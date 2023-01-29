using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            float result;
            
            int x, y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);

            int timeInMinutes = 130;
            int hour;
            int minute;

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;

            Console.WriteLine("hours: " + hour);
            Console.WriteLine("minutes: " + minute);

            int age = 18;
            age = age + 1;
            age++;
            age += 1;
            age -= 1;
            age *= 2;
            age /= 3;

            int result2 = 5 + (12 - 5) * 3 - 1 + 5 * 2;
            Console.WriteLine(result2);
        }
    }
}
