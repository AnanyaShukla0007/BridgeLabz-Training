using System;

// Interface for loanable accounts
interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Abstract BankAccount
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public void SetAccountNumber(string acc) { accountNumber = acc; }
    public string GetAccountNumber() { return accountNumber; }

    public void SetHolderName(string name) { holderName = name; }
    public string GetHolderName() { return holderName; }

    public void SetBalance(double bal) { balance = bal; }
    public double GetBalance() { return balance; }

    public void Deposit(double amount) { balance += amount; }
    public void Withdraw(double amount) { balance -= amount; }

    public void Display()
    {
        Console.WriteLine("Account Number: " + GetAccountNumber());
        Console.WriteLine("Holder Name: " + GetHolderName());
        Console.WriteLine("Balance: " + GetBalance());
    }

    public abstract double CalculateInterest();
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return GetBalance() * 0.04; // 4% interest
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Loan applied for: " + amount);
    }

    public double CalculateLoanEligibility()
    {
        return GetBalance() * 2;
    }
}

// Current Account
class CurrentAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return GetBalance() * 0.01; // 1% interest
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Loan applied for: " + amount);
    }

    public double CalculateLoanEligibility()
    {
        return GetBalance();
    }
}

// Main program
class ProgramBank
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        sa.SetAccountNumber("S101");
        sa.SetHolderName("Rahul");
        sa.SetBalance(50000);

        CurrentAccount ca = new CurrentAccount();
        ca.SetAccountNumber("C101");
        ca.SetHolderName("Anita");
        ca.SetBalance(30000);

        Console.WriteLine("Savings Account:");
        sa.Display();
        Console.WriteLine("Interest: " + sa.CalculateInterest());
        Console.WriteLine("Loan Eligibility: " + sa.CalculateLoanEligibility());
        Console.WriteLine();

        Console.WriteLine("Current Account:");
        ca.Display();
        Console.WriteLine("Interest: " + ca.CalculateInterest());
        Console.WriteLine("Loan Eligibility: " + ca.CalculateLoanEligibility());
    }
}
