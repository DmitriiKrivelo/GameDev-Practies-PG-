using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damage_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*float health;
            int armor;
            int damage;
            int percentConverter = 100;

            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество нанесенного урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / percentConverter * armor ;

            Console.WriteLine($"Вам нанесли {damage} урона. У вас осталось {health} здоровья");*/

            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет.");
            Console.Write("Сколько у вас золота? ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно? ");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= foodUnitPrice * food;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды и {money} золота");
        }
    }
}
