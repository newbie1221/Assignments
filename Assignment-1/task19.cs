using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task19
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string s1=Console.ReadLine();
            string s2 = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                s2 += s1[i];
            }
            if (s2 == s1)
                Console.WriteLine("Its Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
