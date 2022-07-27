using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_coll
{
    internal class task6
    {
        static void Main() { 
           Dictionary<string,List<string>> h=new Dictionary<string, List<string>>();
            Console.WriteLine("Enter how many entries you want to make");
            int x = int.Parse(Console.ReadLine());
            for(int i=0;i<5;i++) {
                h["Program Manager"]=new List<string>();
                h["Project Manager"]=new List<string>();
                h["Team Lead"]=new List<string>();
                h["Senior Programmer"]=new List<string>();
                h["Junior Programmer"]=new List<string>();
            }
            for (int i = 0; i < x; i++) {
                Console.WriteLine("enter designation and name: ");
                string s = Console.ReadLine();
                string s1 = Console.ReadLine();
                h[s].Add(s1);
            }
            foreach (var i in h) {
                if (i.Value.Count > 0) { 
                    List<string> list = i.Value;
                    foreach (string s in list)
                        Console.WriteLine($"Designation: {i.Key} , Name: {s}");
                }
            }

        }
    }
}
