using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пароль с попытками
            /*int triesCount = 5;
            string password = "123456";
            string userInput;

            for(int i = 0; i < triesCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Секретики.");
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неверный пароль.");
                    Console.WriteLine("У вас осталось попыток: " + (triesCount - i - 1));
                }
            }*/

            // Вклад в банке
            /*float money;
            int years;
            int percent;
            Console.Write("Введите количество денег, внесенных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент: ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("в этом году у вас " + money);
                Console.ReadKey();
            }*/

            // Бой с противником
            int playerHealth = 100;
            int playerDamage = 10;
            int enemyHealth = 50;
            int enemyDamage = 15;

            while (playerHealth>0 && enemyHealth>0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " игрок.");
                Console.WriteLine(enemyHealth + " враг.");
            }

            if(playerHealth<=0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья.");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока.");
            }
            else if(playerHealth <= 0)
            {
                Console.WriteLine("Победа врага.");
            }
        }
    }
}
