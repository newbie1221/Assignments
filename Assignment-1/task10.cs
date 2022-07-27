using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task10
    {
        static void Main()
        {
            Console.WriteLine("Enter Value for N");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 5; i <= n; i++)
                sum += Math.Pow(i, 3);
            Console.WriteLine(sum);
        }
    }
}
