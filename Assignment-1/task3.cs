using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task3
    {
        static void Main()
        {
            Console.WriteLine("Give two numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            n1++;
            for(int t=n1;t<n2;t++)
                Console.WriteLine(t);
        }
    }
}
