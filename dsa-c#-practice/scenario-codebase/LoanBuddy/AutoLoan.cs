using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.LoanBuddy
{
    internal class AutoLoan : Loan
    {
        public AutoLoan(Applicant applicant, LoanApplication application)
            : base(applicant, application)
        {
        }

        public override bool ApproveLoan()
        {
            if (applicant.GetCreditScore() >= 650)
            {
                SetApproval(true);
                return true;
            }
            return false;
        }

        public override double CalculateEMI()
        {
            double P = applicant.GetLoanAmount();
            double R = application.InterestRate / (12 * 100);
            int N = application.Term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }
    }
}
