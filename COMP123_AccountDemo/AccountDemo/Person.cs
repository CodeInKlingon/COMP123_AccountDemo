using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Person
    {
        // Private fields
        private string password;

        // Public fields
        public string SIN;

        // Properties
        public bool IsAuthenticated { get; private set; }
        public string Name { get; private set; }

        // Methods
        public Person(string name, string sin)
        {
            SIN = sin;
            Name = name;

            
        }

        public void Login(string password)
        {
            this.password = password;
            if (Account.password != password)
            {
                throw new AccountException(AccountException.IsAuthenticated);
            }
            else
            {
                IsAuthenticated = true;
            }
        }

        public void Logout()
        {
            IsAuthenticated = false;
        }

        public override string ToString()
        {
            return string.Format("{0} is {1}", Name, IsAuthenticated ? "authenticated" : "Not authenticated");
        }
    }
}
