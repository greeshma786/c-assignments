using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment2
{
    class Class2
    {
        public static void Solution()
        {
            Console.WriteLine("cfvgbhjnnbu");
            int[,] a = new int[3,3];
            for(int i = 0; i < 3; i++)
            {
                for(int j=0;j<3;j++)
                {
                    a[i,j]=Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
