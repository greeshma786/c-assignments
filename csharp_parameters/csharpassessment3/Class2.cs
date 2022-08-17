using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassessment3
{
    class Class2
    {
        public static void SUM(params int[] inp)
        {
            int res = 0;
            for(int i = 0; i < inp.Length; i++)
            {
                res += inp[i];
            }
            Console.WriteLine(res);
        }
    }
}
