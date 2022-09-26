using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern_State {
    /// <summary>
    /// Context
    /// </summary>
    public class BankAccount {
        public BankAccountState BankAccountSatate { get; set; }
        public decimal Balance { get { return BankAccountSatate.Balance; } }
        public BankAccount() {
            BankAccountSatate = new RegularState(200, this);
        }

        /// <summary>
        /// Request a withdrawal
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount) {
            // let teh current state handle the deposit
            BankAccountSatate.Deposite(amount);
        }

        /// <summary>
        /// Request a witdrawal
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(decimal amount) {
            // let the current state handle the withdrawel
            BankAccountSatate.Withdraw(amount);
        }

    }
}
