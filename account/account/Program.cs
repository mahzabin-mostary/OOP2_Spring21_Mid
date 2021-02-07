using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{

    class account
    {
        string accname;
        string acid;
        int balance;
        int amount;

        public account()
        {
            Console.WriteLine("empty constructor");
        }
        public account(string accname, string acid, int balance, int amount)
        {
            Console.WriteLine("parametrized constructor");
            this.accname = accname;
            this.acid = acid;
            this.balance = balance;
            this.amount = amount;

        }
        internal void showdetails()
        {
            Console.WriteLine("account details ================================================");
            Console.WriteLine("name: " + accname);
            Console.WriteLine("id : " + acid);
            Console.WriteLine("deposit amount: " + balance);
            Console.WriteLine("withdraw amount: " + amount);
            Console.WriteLine("account details ================================================");
        }
        static void Main(string[] args)
        {
            account obj = new account();
            account obj1 = new account("mahzabin mostary", "6565764647", 578998888, 987655);
            obj1.showdetails();
        }
    }
}
