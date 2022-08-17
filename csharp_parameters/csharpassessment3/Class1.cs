using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassessment3
{
    class Class1
    {
        double d, mc;
        public void Solution(double mc)
        {
            //Console.WriteLine("enter the debt amount");//1000
            d = 1000;// Int64.Parse(Console.ReadLine());
            int t = 0;
            double paid = 0;
            //Console.WriteLine("debt\t month\t paid");
            while (d > 0)
            {
                t += 1;
                paid += mc;
                d += (d * 0.015);
                Console.WriteLine($"month: {t},balance: {d},total payments: {paid}");
                d -= mc;
            }
            Console.WriteLine($"month: {t},balance: {d},total payments: {paid}");
            Console.ReadLine();
        }
    }
}
