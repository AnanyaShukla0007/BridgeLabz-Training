using System;

class BankSystemManager
{
    public User user;
    public Bank bank;

    public void CreateUser()
    {
        user = new User();
        user.customerId = 1;
        user.name = "Ana";
        user.dateOfBirth = "01-01-2000";
        user.aadhaarNumber = "XXXX-XXXX-1234";
        user.accountType = "Savings";
        user.registeredMobile = "9999999999";
    }

    public void CreateAccount()
    {
        bank = new Bank();
        bank.accountNumber = 1001;
        bank.accountBalance = 0;
        bank.accountStatus = "Active";
    }

    public void Deposit(double amount)
    {
        bank.accountBalance += amount;
        Console.WriteLine("Deposit Successful");
    }

    public void Withdraw(double amount)
    {
        if (bank.accountBalance - amount >= Bank.minimumBalance)
        {
            bank.accountBalance -= amount;
            Console.WriteLine("Withdrawal Successful");
        }
        else
        {
            Console.WriteLine("Withdrawal Failed: Minimum Balance Rule");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Balance: " + bank.accountBalance);
    }

    public void ShowCompleteDetails()
    {
        Console.WriteLine("\n--- BANK DETAILS ---");
        Console.WriteLine("Bank Name: " + Bank.bankName);
        Console.WriteLine("IFSC: " + Bank.ifscCode);
        Console.WriteLine("Branch: " + Bank.branchCode);

        Console.WriteLine("\n--- USER DETAILS ---");
        Console.WriteLine("Name: " + user.name);
        Console.WriteLine("Customer ID: " + user.customerId);

        Console.WriteLine("\n--- ACCOUNT DETAILS ---");
        Console.WriteLine("Account Number: " + bank.accountNumber);
        Console.WriteLine("Account Status: " + bank.accountStatus);
        Console.WriteLine("Balance: " + bank.accountBalance);
    }
}
