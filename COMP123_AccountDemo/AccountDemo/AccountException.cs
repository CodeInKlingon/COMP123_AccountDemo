using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class AccountException : Exception
    {
        public const string ACCOUNT_DOES_NOT_EXIST = "Account does not exist";
        public const string CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "Credit limit exceeded";
        public const string NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "Name is not associated with account";
        public const string NO_OVERDRAFT = "No overdraft";
        public const string PASSWORD_INCORRECT = "incorrect password";
        public const string USER_DOES_NOT_EXIST = "User does not exist";
        public const string USER_NOT_LOGGED_IN = "User is not logged in";

        public AccountException()
            : base()
        {

        }
        public AccountException(string type)
            : base()
        {

        }
    }
}
