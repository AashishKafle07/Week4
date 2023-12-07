namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating instance of BankAccount
            BankAccount balance=new BankAccount("12345679",0);

            //Calling Deposite method to deposite 1000
            balance.Deposite(1000);

            //Calling Withdraw method to withdraw 500
            balance.Withdraw(500);

            //Calling the Output method
            balance.Output();
        }
    }
}