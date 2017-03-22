using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    abstract class Account
    {
        //fields
        public readonly List<Person> holders = new List<Person>();
        public readonly List<Transactions> transactions = new List<Transactions>();
        public readonly string Number;
        private int LAST_NUMBER;

        //properties
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        public Account(string type, double balance) {
            Balance = balance;
            LowestBalance = balance;

            Number = type + LAST_NUMBER.ToString();
            LAST_NUMBER++;
        }

        public void AddUser(Person person) {
            holders.Add(person);
        }

        public Deposit(double amount, Person person){
            Balance +=amount;
            LowestBalance = Balance;

            Transaction transaction = new Transaction(DateTime.Now, Number, amount, person, Balance);
            transactions.Add(transaction);

        }

        public bool IsHolder(string name){
            foreach(Person p in holders){
                if(p.name = name){
                    return true;
                }
            }
        }

        public abstract void PrepareMonthlyReport(){}

        public override string ToString() {
            string output = "";
            output += Number;
            foreach(Person p in holders){
                output += p.name;
            }
            output +=Balance;

            foreach(Transaction t in transactions){
                output+=t;
            }

            return output;
        }

    }
}
