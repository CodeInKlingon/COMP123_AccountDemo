using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class SavingAccount : Account
    {
        // Private fields
        private double CostPerTransaction = 0.05;
        private double InterestRate = 0.015;

        //Methods
        public SavingAccount(double balance = 0)
          : base(balance)
        {
 
        }

        public new void Deposit(double amount, Person person)
            : base(balance, Name)
        {

        }

        public void Withdraw(double amount, Person person)
        {
            // Checks in AccountException class

            if (!base.holders.Contains(person))// checks if person is not in holder list from base class
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT); // ACCOUNT_DOES_NOT_EXIST
            }
            else if(!person.IsAuthenticated) {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            else if (amount > base.Balance)
            {
                //This message check if the withdrawal amount if greater than
                //the balance and there is no overdraft facility
                throw new AccountExcertion(AccountException.NO_OVERDRAFT);
            }
            else 
            { 
            Deposit(amount, person);
            }
         }
        
        public override void PrepareMonthlyReport(){
            double transactions =  CostPerTransaction * transactions;
            double interest = (balance * InterestRate) / 12;
            balance = ((balance + interest) - transactions;
        }
    }
}
