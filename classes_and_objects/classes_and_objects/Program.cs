using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard obj1 = new CreditCard();
            obj1.Solution(100);


            Account obj2 = new Account();
            obj2.Accept("15200", "fghj", "savings", 'd', 200, 5000);
            obj2.showdata();


            int[] v = new int[5] { 71, 82, 93, 44, 58 };
            Student obj30 = new Student("12345","name",1,7,"it", v);
            obj30.displaydata();
            v = new int[5] { 35,70,90,50,20 };
            Student obj31 = new Student("12345", "name", 1, 7, "it", v);
            obj31.displaydata();
            v = new int[5] { 40,40,37, 37,37};
            Student obj32 = new Student("12345", "name", 1, 7, "it", v);
            obj32.displaydata();


            /*BookDetails obj = new BookDetails();
            obj.b_no = Int32.Parse(Console.ReadLine());
            obj.bookauthor = Console.ReadLine();
            obj.bookname = Console.ReadLine();
            obj.booktitle = Console.ReadLine();
            obj.quantityofbooks = Int32.Parse(Console.ReadLine());
            obj.bookprice = Int64.Parse(Console.ReadLine());
            Console.WriteLine(obj.DisplayBookDetails());
            Console.WriteLine("money required to purchase is {0}", obj.calculatePrice());*/

            Shape obj5 = new Shape();
            Console.WriteLine(obj5.Area(10));//square
            Console.WriteLine(obj5.Area(5, 3));//rectangle
            Console.WriteLine(obj5.Area(3.2f));//circle
            Console.WriteLine(obj5.Area(2.2f, 1.1f));//triangle

            BankAccount obj6 = new BankAccount();
            obj6.Initialize("abc", "2343534535", "savings");
            obj6.details();
            obj6.deposit(1000); obj6.details();
            obj6.withdraw(200); obj6.details();

            student2 obj7 = new student2();
            obj7.RollNo = "787567";
            obj7.StudName = "name";
            obj7.MarksInEng = 91;
            obj7.MarksInMaths = 99;
            obj7.MarksInScience = 88;
            obj7.totalmarks();
            obj7.percentage();

            Console.ReadLine();
        }
    }
}
