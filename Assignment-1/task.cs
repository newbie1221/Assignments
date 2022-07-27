using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task
    {
        static void Main()
        {
            Console.WriteLine("enter number");
            int k = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (k != 0)
            {
                m *= k;
                k--;
            }
            Console.WriteLine($"{m}");
        }
    }
}
