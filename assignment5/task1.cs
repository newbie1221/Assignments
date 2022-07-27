using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class task1
    {
        public int rollno;
        public string name;
        public int clas;
        public int SEM;
        public string branch;
        public int[] marks=new int[5];
    }
    class task2 {
        public task1 student = new task1();
        
        public task2(int roll, string name, int clas, int sem, string branch, params int[] x)
        {
            
                student.rollno = roll;
                student.name=name;
                student.clas = clas;
                student.SEM = sem;
                student.branch = branch;
                for(int i=0;i<5;i++)
                    student.marks[i] = x[i];
        }
        public void result() {
            
                    int avg = 0,flag=0;
                    for (int j = 0; j < 5; j++) {
                        avg += student.marks[j];
                        if(student.marks[j]<35)
                            flag = 1;
                    }
                    avg /= 5;
                    if (avg < 50)
                        flag = 1;
                    if (flag == 1)
                        Console.WriteLine($"Name: {student.name}, Average: {avg} , Status: Failed");
                    else
                        Console.WriteLine($"Name: {student.name}, Average: {avg} , Status: Passed");

              
        }

        public void display() {
            
                Console.WriteLine($"Rollno: {student.rollno}, Name: {student.name}, Branch: {student.branch}, Semester: {student.SEM}, Class: {student.clas}");
            
        }
    }
    class proxy {
        static void Main() {
            task2 t = new task2(1815001,"Debopriyo",5,6,"CSE",70,80,90,90,50);
            t.display(); //for displaying details of student
            t.result(); //for checking result of student
        }
    }
}
