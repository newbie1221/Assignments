using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task11
    {
        static void Main()
        {
            Console.WriteLine("Give a number");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{k} x {i}={k * i}");
            }
        }
    }
}
