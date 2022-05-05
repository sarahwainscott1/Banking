using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    //savings using composition
    internal class SavingsComp {
        //properties
        private Account? _Account { get; set; } = null; //objects are allowed to start with _ ( just using to differentiate variable, ?allows type to be null
        //above is how we are linking this class to Account class
        public string Name {
            get { return _Account.Name; } //uses this to refer to _Account, which is an instance of Account
            set { _Account.Name = value; } 
        }
        public int AcctNbr {
            get { return _Account.AcctNbr; } //no set since acctnbr is private in account, can read acctnbr, but not change it
        }
        public decimal Balance {
            get { return _Account.Balance; } //same as above, read, but not set
        }
        public decimal InterestRate { get; set; } = 0.12m;

        //methods
        public void PayInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }
        public bool Deposit(decimal amount) { //Account has deposit built in, so don't have to fully rewrite, can use composition
            return _Account.Deposit(amount);
        }
        public bool Withdraw(decimal amount) { 
            return _Account.Withdraw(amount); 
        }

        public bool Transfer(decimal amount, Account ToAccount) {
            return _Account.Transfer(amount, ToAccount);
        }

        //constructor
        public SavingsComp() {
            _Account = new Account(); //instance of Account is being pulled in here, being stored in instance _Account
        }


    }
}
