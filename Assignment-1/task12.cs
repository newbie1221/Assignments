using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task12
    {
        static void Main()
        {
            for (int i = 201; i <300; i++)
            {
                if (i % 7 == 0)
                    Console.Write($"{i} ");
            }
        }
    }
}
