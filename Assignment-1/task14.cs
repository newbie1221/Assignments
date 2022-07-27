using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task14
    {
        static void Main()
        {
            int min =10000;
            Console.WriteLine("Give five numbers");
            int n1 = int.Parse(Console.ReadLine());
            min=Math.Min(min, n1);
            int n2 = int.Parse(Console.ReadLine());
            min = Math.Min(min, n2);
            int n3 = int.Parse(Console.ReadLine());
            min = Math.Min(min, n3);
            int n4 = int.Parse(Console.ReadLine());
            min = Math.Min(min, n4);
            int n5 = int.Parse(Console.ReadLine());
            min = Math.Min(min, n5);
            Console.WriteLine($"Smallest number: {min}");

        }
    }
}
