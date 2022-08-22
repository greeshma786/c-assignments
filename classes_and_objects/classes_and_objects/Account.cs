using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Account
    {
        public string ACCOUNT_no { get; set; }
        public string Customer_name { get; set; }
        public string Account_type { get; set; }
        public char Transaction_type { get; set; }
        public double amount { get; set; }
        public double balance { get; set; }
        public void Accept(string ACCOUNT_no,string Customer_name,string Account_type,char Transaction_type ,double amount,double balance)
        {
            this.ACCOUNT_no = ACCOUNT_no;
            this.Customer_name = Customer_name;
            this.Account_type = Account_type;
            this.Transaction_type = Transaction_type;
            this.amount = amount;
            this.balance = balance;
            if (this.Transaction_type == 'd')
                this.credit(amount);
            else if (this.Transaction_type == 'w')
                this.debit(amount);
        }
        public void credit(double amount)
        {
            this.balance += amount;
            Console.WriteLine(balance);
        }
        public void debit(double amount)
        {
            this.balance -= amount;
            Console.WriteLine(balance);
        }
        public void showdata()
        {
            Console.WriteLine("ACCOUNT no\t Customer name\t Account type\t Transaction type \t amount\t balance");
            Console.WriteLine($"{ ACCOUNT_no}\t{ Customer_name}\t {Account_type}\t {Transaction_type}\t{amount}\t{balance}");
        }
    }
}
