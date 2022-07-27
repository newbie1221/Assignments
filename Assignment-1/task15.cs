using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task15
    {
        static void Main()
        {
            Console.WriteLine("Give 10 Marks :");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
                sum += arr[i];
            Console.WriteLine($"Average is: {sum/10}");
            Array.Sort(arr);
            Console.WriteLine($"Minimum Marks: {arr[0]}");
            Console.WriteLine($"Minimum Marks: {arr[9]}");
            for (int i = 0; i < 10; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
            for (int i = 9; i >= 0; i--)
                Console.Write($"{arr[i]} ");
        }
    }
}
