using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class BankAccount
    {
        //Properties
        private string AccountNumber;
        private decimal Balance;

        //Constructor
        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        //Creating method that deposits money.
        public void Deposite(decimal amount)
        {
            Balance = amount + Balance;
        }

        //Creating method that withdraws money
        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
        }

        //Method to print the details of balance
        public void Output()
        {
            Console.WriteLine($"Your total balance is {Balance}");
        }
    }
}
