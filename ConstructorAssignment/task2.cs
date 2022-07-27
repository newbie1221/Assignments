using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class task2
    {
        string type;
        string capacity;
        string dateocomp;
        string dimension="NULL";
        int floor=0;
        public task2(string t,string c, string da,string di) { 
            this.type = t;
            this.capacity = c;  
            this.dateocomp = da;    
            this.dimension = di;
        }
        public task2(string t, string c, string da, int val)
        {
            this.type = t;
            this.capacity = c;
            this.dateocomp = da;
            this.floor=val;
        }
        public void show() {
            Console.WriteLine(type);
            Console.WriteLine(capacity);
            Console.WriteLine(dateocomp);
            Console.WriteLine(dimension);
            Console.WriteLine(floor);
        }
    }
    class uno {
        static void Main() {
            task2 t = new task2("f", "2bhk", "19/03/2023", 9);
            t.show();
            Console.WriteLine();
            task2 t1 = new task2("v", "4", "7/07/2020","200x300x40");
            t1.show();

        }
    }
}
