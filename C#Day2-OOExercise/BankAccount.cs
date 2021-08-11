using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myappAug10
{
    class BankAccount
    {
        /// <summary>
        /// Create a class called BankAccount and have default constructor 
        /// to take balance as 500 and another parameterized to take other than 500.
        /// </summary>
        float balance;
        public BankAccount()
        {
            this.balance = 500;
        }
        public BankAccount(float bal)
        {
            this.balance = bal;
        }
        public string getBalance()
        {
            return $"Balance = {this.balance}";
        }
    }
    class Bank
    {
     public static void Main()
        {
            //float x;
            BankAccount b = new BankAccount();
            Console.WriteLine($"Default balance is {b.getBalance()}");
            
            BankAccount b1 = new BankAccount(1000);
            Console.WriteLine($" Balance of b1 is {b1.getBalance()}");
        }
    }

}
