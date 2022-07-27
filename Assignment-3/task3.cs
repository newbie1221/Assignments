using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class task3
    {
        static void proxy(int a, int b)
        {
            Console.WriteLine($"{a}+{b} : {a + b}");
        }
        static void Main() { 
            proxy(2,3);
        }
    }
}
