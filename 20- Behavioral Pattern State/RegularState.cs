using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern_State {
    public class RegularState : BankAccountState {
        public RegularState(decimal balance, BankAccount bankAccount) {
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposite(decimal amount) {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
            if (Balance >= 1000) {
                // change state to gold
                BankAccount.BankAccountSatate = new GoldState(Balance, BankAccount);
            }
        }

        public override void Withdraw(decimal amount) {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            // change state to overdrawn when withdrawing results in less than zero
            Balance -= amount;
            if (Balance < 0) {
                // change state to overdrawn
                BankAccount.BankAccountSatate = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
