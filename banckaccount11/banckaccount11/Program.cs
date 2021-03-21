using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banckaccount11
{
    class Account
    {
        public string AccName { get; set; }
        public string Accid { get; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accName, string accid, double balance)
        {
            AccName = accName;
            Accid = accId;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccId);
            Console.WriteLine("Balance: " + Balance);

        }
        virtual public void Withdraw(double amount)
        {

        }
        virtual public void Transfer(Account acc, double amount)
        {

        }
        static void Main(string[] args)
        {


            Account obj = new Account("mahzabin", "1111", 50000);
           obj.ShowInfo();



        }
    }
}

    }
}