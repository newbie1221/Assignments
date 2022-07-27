using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment_3
{
    class Task2
    {
        static void Main()
        {
            string s="Dotnet is technology and Dotnet is interoperable and Dotnet is simple";
            string[] s1=s.Split(" ");
           
            ArrayList a = new ArrayList();
            foreach (string i in s1) {
                if (!a.Contains(i)) {
                    int count = 0;
                    foreach (string j in s1)
                    {
                        if (i == j) count++;
                    }
                    a.Add(i);
                    Console.WriteLine($"{i} : {count}");
                }
            }
        }
    }
}
