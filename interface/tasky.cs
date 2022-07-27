using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    interface GovtRules {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }

    class TCS : GovtRules {
        long empid;
        public long Empid { get; set; }
        string name;
        public string Name { get; set; }
        string dept;
        public string Dept { get; set; }
        string desg;
        public string Desg { get; set; }
        long basic;
        public double Basic { get; set; }
        public double EmployeePF(double basicSalary) {
            double x = (0.12 * basicSalary) + (0.0833 * basicSalary) + (0.0367*basicSalary);
            return x;
        }
        public string LeaVeDetails() {
            string s = @"1 day of Casual Leave per month
12 days of Sick Leave per year
10 days of Previlage Leave per year
";
            return s;
        }
        public double gratuityAmount(float serviceCompleted, double basicSalary) {

            if (serviceCompleted < 5)
                return 0;
            else if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if(serviceCompleted>10)
                return 2 * basicSalary; 
            return 1 * basicSalary;

        }
        public TCS(long x,string s1,string s2,string s3, double d) {
            this.Empid = x;
            this.Name = s1;
            this.Dept = s2;
            this.Desg = s3;
            this.Basic = d;
        }
        public void show()
        {
            Console.WriteLine($"ID: {Empid}, Name: {Name}, Deartment: {Dept}, Designation: {Desg}, Sallary: {Basic}");
        }
    }



    class Accenture : GovtRules
    {
        long empid;
        public long Empid { get; set; }
        string name;
        public string Name { get; set; }
        string dept;
        public string Dept { get; set; }
        string desg;
        public string Desg { get; set; }
        long basic;
        public double Basic { get; set; }
        public double EmployeePF(double basicSalary)
        {
            double x = (0.12 * basicSalary) + (0.0833 * basicSalary) + (0.0367 * basicSalary);
            return x;
        }
        public string LeaVeDetails()
        {
            string s = @"2 day of Casual Leave per month
5 days of Sick Leave per year
5 days of Previlage Leave per year
";
            return s;
        }
        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {

            return 0;
        }
        public Accenture(long x, string s1, string s2, string s3, double d)
        {
            this.Empid = x;
            this.Name = s1;
            this.Dept = s2;
            this.Desg = s3;
            this.Basic = d;
        }
        public void show() {
            Console.WriteLine($"ID: {Empid}, Name: {Name}, Deartment: {Dept}, Designation: {Desg}, Sallary: {Basic}");
        }
    }
    class Proxy {

        static void Main() {
            TCS t = new TCS(1815001,"Debopriyo","CSE","Student",14000);
            t.show();
            double d = t.EmployeePF(14000);
            Console.WriteLine($"Employee PF: {d}");
            double d1 = t.gratuityAmount(15,14000);
            Console.WriteLine($"Gratuity Amount: {d1}");
            string s=t.LeaVeDetails();
            Console.WriteLine($"Leave: {s}");
        }
    }
}
