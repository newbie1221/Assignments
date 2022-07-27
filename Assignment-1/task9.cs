using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task9
    {
        static void Main()
        {
            int x = 0, y = 1;
            Console.WriteLine("0 ");
            Console.WriteLine("1 ");
            while (true)
            {
                int temp = y;
                y = x + y;
                x = temp;
                if (y <= 40)
                    Console.WriteLine($"{y} ");
                else
                    break;

            }
        }
    }
}
