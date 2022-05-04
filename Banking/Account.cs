using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    internal class Account {
        private static int NextId = 1;
        public int AcctNbr { get; private set; } = 0; //private set says can only change within account class, not in program
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; private set; } = 0;

        public bool Deposit(decimal Amount) {
            if (Amount < 0) {
                Console.WriteLine("Amount must be greater than 0.");
                return false;
                }
            Balance = Balance + Amount;
            return true; 
            }
        public bool Withdraw(decimal Amount) {
                if (Amount < 0) {
                    Console.WriteLine("Amount must be greater than 0.");
                    return false;
                    }
                if (Amount > Balance) { //error statement
                        Console.WriteLine("Insufficient Balance :(");
                        return false;
                     }
                Balance = Balance - Amount;
                return true;
                }
        public bool Transfer(decimal Amount, Account DAccount) { //assume withdraw from this acct, must set deposit account
            if(Withdraw(Amount)) { //already returns a boolean so no need to type it as a boolean here
                DAccount.Deposit(Amount); //sets deposits to go to daccount
                return true;
                }
            return false;
            }

        public Account() {
            AcctNbr = NextId++;
            }
        }
    }
