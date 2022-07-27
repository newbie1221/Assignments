using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class task18
    {
        static void Main()
        {
            Console.WriteLine("Enter two strings");
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("Both words are same");
            else
                Console.WriteLine("Words are not same");
        }
    }
}
