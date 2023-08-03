using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class Friend
    {
        public BankAccount Account { get; set; }

        public void LendMoney(Friend to, int amount)
        {
            if(Account.Balance >= amount)
            {
                Account.Balance -= amount;
                to.AcceptMoney(amount);
            }
        }

        public void AcceptMoney(int amount)
        {
            Account.Balance += amount;
        }
    }
}
