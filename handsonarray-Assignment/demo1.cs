using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonarray
{
    internal class demo1
    {
        static void Main()
        {
            int[][] jg = new int[3][];
            jg[0] = new int[5] { 1, 2, 3, 4, 5 };
            jg[1]=new int[3] { 1, 2, 3};
            jg[2]=new int[2] { 1, 2};
            Console.WriteLine(jg[0].Length);
        }
    }
}
