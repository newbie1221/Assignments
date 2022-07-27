using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_coll
{   class student {
        int sid;
        public int Sid { get; set; }
        string name;
        int marks;
        public string Name { get; set; }
        public int Marks { get; set; }  
    }
    internal class task5
    {
        static void Main() { 
            ArrayList a=new ArrayList();
            a.Add(new student() { Sid=1815001, Name="Debopriyo", Marks=98});
            a.Add(new student() { Sid = 1815002, Name = "Rituraj", Marks = 90 });
            a.Add(new student() { Sid = 1815003, Name = "Manas", Marks = 99 });
            a.Add(new student() { Sid = 1815004, Name = "Bania", Marks = 91 });
            a.Add(new student() { Sid = 1815005, Name = "Neelotpol", Marks = 93 });
            foreach (var i in a) {
                student s = (student)i;
                Console.WriteLine($"ID: {s.Sid}, Name: {s.Name}, Marks: {s.Marks}");
            }

        }
    }
}
