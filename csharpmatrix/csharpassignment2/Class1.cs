using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment2
{
    class Class1
    {
        public static void Solution()
        {
            double p = 1000.00;// Int64.Parse(Console.ReadLine());
            int yr = 0;
            while(p< 100000)
            {
                yr += 1;
                p += (p * 0.05);
            }
            Console.WriteLine($"{p} in {yr}");
            Console.ReadLine();
        }
    }
}
