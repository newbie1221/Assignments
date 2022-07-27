using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonarray
{
    internal class demo3
    {
        static void Main()
        {
            int[,] check = new int[3, 3];
            Console.WriteLine("Give input for 3x3 Matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    check[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{check[i,j]}  ");
                    
                }
                Console.Write("\n"); 
            }
        }
    }
}
