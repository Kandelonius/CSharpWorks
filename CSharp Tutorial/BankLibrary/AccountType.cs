using System;
using System.Collections.Generic;
using System.Text;

/*
 * an exercise in polymorphism
 */

namespace BankLibrary
{
    class AccountType
    {
        // this will take in the account type which will be used to determine the greeting
        private string type;

        public AccountType(string type)
        {
            this.type = type;
        }

        // this greeting will display a message relevant to the account type
        public virtual string greeting()
        {
            // default message indicating an account type was requested that isn't useful
            return "Not a valid account";
        }

    }
}
