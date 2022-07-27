using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task5
    {
        static void Main()
        {
            Console.WriteLine("Give 6 numbers");
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            int k3 = Convert.ToInt32(Console.ReadLine());
            int k4 = Convert.ToInt32(Console.ReadLine());
            int k5 = Convert.ToInt32(Console.ReadLine());
            int k6 = Convert.ToInt32(Console.ReadLine());
            int odd = 0, even = 0;
            if(k1%2==0)
                even++;
            else
                odd++;
            if (k2 % 2 == 0)
                even++;
            else
                odd++;
            if (k3 % 2 == 0)
                even++;
            else
                odd++;
            if (k4 % 2 == 0)
                even++;
            else
                odd++;
            if (k5 % 2 == 0)
                even++;
            else
                odd++;
            if (k6 % 2 == 0)
                even++;
            else
                odd++;

            Console.WriteLine($"Total odd numbers: {odd} and total even numbers: {even}");

        }
    }
}
