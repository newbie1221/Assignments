using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_coll
{
    internal class task2
    {
        static void Main() { 
            ArrayList a=new ArrayList();
            Console.WriteLine("Enter names of 10 students");
            for (int i = 0; i < 10; i++) a.Add(Console.ReadLine());
            a.Sort();
            for(int i=9;i>=0;i--)
                Console.Write(a[i]+" ");
        }
    }
}
