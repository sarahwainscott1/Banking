using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking { 
    //savings using inheritance
    internal class Savings : Account { //starts identical to account, need to add some features
        //properties
        public decimal InterestRate { get; set; } = 0.12M; //annual interest rate

        //methods
        //caluclate interest monthly, but only deposit every 'n' months
        private decimal CalculateInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            return interest;
        }
        public void PayInterest(int months) {
            var interest = CalculateInterest(months);
            Deposit(interest);
        }
        //constructors
        public Savings() { } //default - no parameters

    }
}
