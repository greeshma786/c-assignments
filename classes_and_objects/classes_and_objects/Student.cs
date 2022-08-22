using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Student
    {
        public string rollno { get; set; }
        public string name { get; set; }
        public int classofstudy { get; set; }
        public int SEM { get; set; }
        public string branch { get; set; }
        public int[] marks { get; set; }

        public Student(string rollno,string name,int classofstudy,int SEM,string branch, int[] marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.classofstudy = classofstudy;
            this.SEM = SEM;
            this.branch = branch;
            this.marks = marks;
        }
        public void displayresult()
        {
            int flag = 1, total=0 ;
            foreach(var i in this.marks)
            {
                if (i < 35)
                {
                    flag = 0;
                    break;
                }
                total += i;
            }
            float avg = total / 5;
            if (flag == 1 && avg >= 50)
                Console.WriteLine("passed");
            else
                Console.WriteLine("failed");
        }
        public void displaydata()
        {
            Console.WriteLine($"{rollno}, {name}, {classofstudy}, {SEM}, {branch}\nmarks:");
            foreach(var k in this.marks)
            {
                Console.Write($"{k} ");
            }
            this.displayresult();
        }
    }
}
