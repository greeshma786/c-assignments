using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class BankAccount
    {
        public string name { get; set; }
        public string accno { get; set; }
        public string acctype { get; set; }
        public double balance{ get; set; }
        public void Initialize( string name,string accno,string acctype,double balance=0)
        {
            this.name = name;
            this.accno = accno;
            this.acctype = acctype;
            this.balance = balance;
        }
        public void deposit(double amt)
        {
            this.balance += amt;
        }
        public void withdraw(double amt)
        {
            if (this.balance >= amt)
                this.balance -= amt;
            else
                Console.WriteLine("insufficient balance");
        }
        public void details()
        {
            Console.WriteLine($"name:{this.name}\naccount number:{this.accno}\nbalance:{this.balance}");
        }
}
}
