using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == != > >= <= <
            int age = 18;
            bool accessIsAllowed;

            accessIsAllowed = age >= 18;
            Console.WriteLine(accessIsAllowed);

            bool check;
            check = 5 == 5;
            Console.WriteLine(check);
        }
    }
}
