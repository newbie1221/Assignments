using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_coll
{
    internal class task3
    {
        static void Main() { 
            SortedList s=new SortedList();
            s.Add(1815001, "Debopriyo");
            s.Add(1815009, "akash");
            s.Add(1815011, "jalan");
            s.Add(1815099, "jackel");
            s.Add(1815003, "vinod");
            foreach (var i in s.Keys) { 
                Console.WriteLine($"ID: {i} , Name: {s[i]}");
            }
        }
    }
}
