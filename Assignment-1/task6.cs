using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task6
    {
        static void Main()
        {
            Console.WriteLine("Enter temp");
            double d = double.Parse(Console.ReadLine());
            double cell = (d - 32) / 1.8;
            Console.WriteLine($"Temperature in celsius : {cell}");
        }
    }
}
