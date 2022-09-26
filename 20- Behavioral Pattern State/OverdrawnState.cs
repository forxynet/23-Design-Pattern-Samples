using Behavioral_Pattern_State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern_State {
    /// <summary>
    /// ConcreteSatate
    /// </summary>
    public class OverdrawnState : BankAccountState {

        public OverdrawnState(decimal balance, BankAccount bankAccount) {
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposite(decimal amount) {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
            if (Balance >=0) {
                // change state to regular
                BankAccount.BankAccountSatate = new RegularState(Balance, BankAccount);
            }
        }

        public override void Withdraw(decimal amount) {
            // Cannot withdrow
            Console.WriteLine($"In {GetType()}, cannot withdrawing, balance {Balance}");           
        }
    }
}
