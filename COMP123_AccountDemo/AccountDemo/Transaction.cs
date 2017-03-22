using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class Transaction
    {
        public readonly string AccountNumber;
        public readonly double Amount;
        public readonly double EndBalance;
        public readonly Person Originator;
        public readonly DateTime Time;

        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time) {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }

        public override string ToString()
        {
            return String.Format("Account Number: {0}. {1}{2}. Balance after transaction: {3}. Person performing transaction: {4}. Time of transaction: {5}", AccountNumber, Amount < 0 ? "Withdraw amount:" : "Deposit amount", Amount, EndBalance, person, Time.ToShortTimeString );
        }


    }
}
