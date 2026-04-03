class Program
{
   static void Main()
   {
       BankSystemManager manager = new BankSystemManager();

       manager.CreateUser();
       manager.CreateAccount();

       manager.Deposit(5000);
       manager.Withdraw(2000);
       manager.CheckBalance();

       manager.ShowCompleteDetails();
   }
}
