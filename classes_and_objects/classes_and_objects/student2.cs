using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class student2
    {
        public string RollNo { get; set; }
        public string StudName { get; set; }
        public int MarksInEng { get; set; }
        public int MarksInMaths { get; set; }
        public int MarksInScience { get; set; }
        public int marks { get; set; }
        public int percent { get; set; }
        public void totalmarks()
        {
            this.marks = MarksInEng + MarksInMaths + MarksInScience;
            Console.WriteLine("total marks:{0}", marks);
        }
        public void percentage()
        {
            this.percent = this.marks / 3;
            Console.WriteLine("percentage is {0}", this.percent);
        }
    }
}
