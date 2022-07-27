using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task4
    {
        static void Main()
        {
            Console.WriteLine("Give a number");
            int k = int.Parse(Console.ReadLine());
            if (k % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
