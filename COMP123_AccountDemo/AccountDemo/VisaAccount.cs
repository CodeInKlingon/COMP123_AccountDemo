//Devin Young
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class VisaAccount : Account
    {
        private double creditLimit;
        public double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance = 0, double creditLimit = 1200)
            :base ("VS-", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }

        public void DoPurchase(double amount, Person person)
        {
            if (!base.holders.Contains(person))
            {
                throw AccountException(AccountException.ACCOUNT_DOES_NOT_EXIST);
            }
            else if (!person.IsAuthenticated)
            {
                throw AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            else if (base.Balance < amount)
            {
                throw AccountException(AccountException.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            }
            else
            {
                base.Deposit(amount, person);
            }
        }
        public override void PrepareMonthlyReport()
        {
            INTEREST_RATE = (LowestBalance * INTEREST_RATE) / 12;

            Balance -= INTEREST_RATE;

            transactions = new List<Transactions>();
        }
        
    }
}
