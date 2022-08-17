using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_properties_assignment
{
    class ClassBook
    {
        public int b_no { get; set; }
        public string bookname { get; set; }
        public string booktitle { get; set; }
        public string bookauthor{ get; set; }
        public int quantityofbooks { get; set; }
        public double bookprice { get; set; }
        public string DisplayBookDetails()
        {
            return $"B_no: {b_no}\nbookname:{bookname}\nbooktitle{booktitle}\nbookauthor:{bookauthor}\nquantityofbooks:{quantityofbooks}\nbookprice:{bookprice}";
        }
        public double calculatePrice()
        {
            return this.bookprice * this.quantityofbooks;
        }


    }
}
