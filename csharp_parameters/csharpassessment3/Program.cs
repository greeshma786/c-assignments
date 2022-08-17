using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("enter monthly payment");//100
            long mc = Int64.Parse(Console.ReadLine());
            obj.Solution(mc);
            Class2 add = new Class2();
            Class2.SUM(10, 20, 30);//calculating sum for 3 parameters
            Class2.SUM(1, 2, 3, 4, 5, 6, 7, 8);//calculating for 8 parameters
            Console.ReadLine();
        }
    }
}
