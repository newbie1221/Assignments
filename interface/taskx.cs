using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    abstract class taskx
    {
        public abstract void Run(int x);
        public void Run2(int x) { Console.WriteLine($"Monthly Sales: Rs.{x * 30}"); }
    }
    interface task0
    {
        public void Run0(int x);
    }
    class task1 : taskx, task0
    {
        public void Run0(int x) { Console.WriteLine($"Annual Sales: Rs.{x * 365}"); }
        public override void Run(int x)
        {
            Console.WriteLine($"Daily Sales: Rs.{x}");
        }
    }
    class task3
    {
        static void Main()
        {
            task1 t = new task1();
            t.Run(400);
            t.Run2(400);
            t.Run0(400);
        }


    }

}


