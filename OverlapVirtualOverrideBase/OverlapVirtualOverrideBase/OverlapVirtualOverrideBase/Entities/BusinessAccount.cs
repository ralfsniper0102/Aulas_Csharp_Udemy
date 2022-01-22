using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(double loanLimit, int number, string holder, double balance)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance = Balance + amount;
            }


        }
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //reuse
            Balance = Balance - 2.00;
        }
    }
}