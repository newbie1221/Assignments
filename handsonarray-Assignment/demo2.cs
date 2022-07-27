using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonarray
{
    internal class demo2
    {
        static void Main()
        {
            Console.WriteLine("Year    Interest of the Year    End of the year amount");
            double i = 1,x=0,y=1000,z=100000;
            while (y < z)
            {
                x = y * 0.05;
                
                Console.WriteLine($"{i}    {y}x0.05={x}    {y + x}");
                y = y + x;
                i++;

            }
        }
    }
}
