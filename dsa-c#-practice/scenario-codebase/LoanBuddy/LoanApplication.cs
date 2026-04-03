using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.LoanBuddy
{
    internal class LoanApplication
    {
        public string LoanType { get; set; }
        public int Term { get; set; }           // months
        public double InterestRate { get; set; } // annual %

        public LoanApplication(string loanType, int term, double interestRate)
        {
            LoanType = loanType;
            Term = term;
            InterestRate = interestRate;
        }
    }
}
