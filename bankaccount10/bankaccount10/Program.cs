using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount10
{
    public class transaction
    {
        public string sender;
        public string receiver;
        public int amount;
        string additionalinfo;
        public transaction(){
             Console.WriteLine(" this is a defult constructor");

            }
        public transaction(string sender, string receiver, int amount, string additionalinf)
        { 
            this.amount = amount;
            this.sender = sender;
            this.receiver = receiver;
            this.additionalinfo = additionalinfo;
            Console.WriteLine(" this is a parametarized constructor");
        }

        
        public void ShowInfo()
        {
            Console.WriteLine("==========");
            Console.WriteLine("Account sender: " + sender);
            Console.WriteLine("Account reciver: " + receiver);
            Console.WriteLine("Current additional info: " + additionalinfo);
            Console.WriteLine("Current amount: " + amount);
            Console.WriteLine("==========");
        }

        static void Main(string[] args) {

        transaction  a1 = new transaction ("monisha"," mon", 500000,"null");
        
            a1.ShowInfo();
            


        }
}
}
