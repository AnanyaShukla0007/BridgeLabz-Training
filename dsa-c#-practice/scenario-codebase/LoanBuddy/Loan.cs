using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.LoanBuddy
{
    internal abstract class Loan : IApprovable
    {
        protected Applicant applicant;
        protected LoanApplication application;
        protected bool isApproved;

        public Loan(Applicant applicant, LoanApplication application)
        {
            this.applicant = applicant;
            this.application = application;
        }

        protected void SetApproval(bool status)
        {
            isApproved = status;
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }
}
