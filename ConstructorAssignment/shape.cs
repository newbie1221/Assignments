using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class shape1
    {
        double area = 0;
        public shape1(int s) {
            area = s * s;
        }
        public shape1(int l, int b)
        {
            area = l * b;
        }
        public shape1(double l, double b) {
            area = 0.5 * l * b;
        }
        public shape1(double r) {
            area = Math.PI * r * r;
        }
        public void show() { Console.WriteLine(area); }
    }
    class shape{
        static void Main() {
            shape1 s = new shape1(3);
            s.show();
            shape1 s1 = new shape1(3, 4);
            s1.show();
            shape1 s2 = new shape1(7d, 9d);
            s2.show();
            shape1 s3 = new shape1(2d);
            s3.show();
        }
    }
}
