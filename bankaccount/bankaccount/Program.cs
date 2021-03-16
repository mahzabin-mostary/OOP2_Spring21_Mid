using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class Program
    {
      

namespace BankAccount
    {
         abstruct class Customer
        {
            public string Name { get; set; }
            Account[] accounts;
            public int AccCount { get; set; }
            public Customer()
            {
                accounts = new Account[10];
            }
            public void AddAccount(params Account[] accounts)
            {
                foreach (Account acc in accounts)
                {
                    this.accounts[AccCount++] = acc;
                }
            }
            public void ShowAccDetails()
            {
                for (int i = 0; i < AccCount; i++)
                {
                    accounts[i].ShowInfo();
                }
            }
            public Account GetAccount(string accNo)
            {
                Account acc = null;
                for (int i = 0; i < AccCount; i++)
                {
                    if (accNo.Equals(accounts[i].AccNo))
                    {
                        acc = accounts[i];
                        break;
                    }
                }
                return acc;
            }
            abstruct class SavingsAccount : Account
        {
            public SavingsAccount() { }
            public SavingsAccount(string accName, string accNo, double balance) : base(accName, accNo, balance)
            {

            }
            public override void Withdraw(double amount)
            {
                if (Balance - amount >= 500)
                {
                    Balance -= amount;
                    Console.WriteLine("Your acc has been debited by {0} to self", amount);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance: Min Balance 500");
                }
            }
            public override void Transfer(Account acc, double amount)
            {
                if (Balance - amount >= 500)
                {
                    this.Balance -= amount;
                    acc.Balance += amount;
                    Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
                }
            }

        }
    }
}
    }
}
