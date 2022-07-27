using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task13
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if (n2 > n1)
            {
                if (n3 > n2)
                    Console.WriteLine($"{n3}");
                else
                    Console.WriteLine($"{n2}");
            }
            else
            {
                if(n1 > n3)
                    Console.WriteLine($"{n1}");
                else
                    Console.WriteLine($"{n3}");
            }
        }
       
    }
}
