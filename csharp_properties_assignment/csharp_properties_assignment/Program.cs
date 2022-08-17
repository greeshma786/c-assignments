using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_properties_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBook obj = new ClassBook();
            obj.b_no = Int32.Parse(Console.ReadLine());
            obj.bookauthor = Console.ReadLine();
            obj.bookname = Console.ReadLine();
            obj.booktitle = Console.ReadLine();
            obj.quantityofbooks = Int32.Parse(Console.ReadLine());
            obj.bookprice = Int64.Parse(Console.ReadLine());
            Console.WriteLine(obj.DisplayBookDetails());
            Console.WriteLine("money required to purchase is {0}",obj.calculatePrice());
            Console.ReadLine();
        }
    }
}
