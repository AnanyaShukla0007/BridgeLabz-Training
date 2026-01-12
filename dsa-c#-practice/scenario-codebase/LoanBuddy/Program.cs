using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.LoanBuddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant =
                new Applicant("Ana", 720, 80000, 500000);

            LoanApplication application =
                new LoanApplication("Home", 240, 8.5);

            Loan loan = new HomeLoan(applicant, application);

            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved");
                Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }

            Console.ReadLine();
        }
    }
}
