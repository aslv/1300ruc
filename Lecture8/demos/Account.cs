using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture8Demos
{
    class Account
    {
        private readonly string id;
        private string firstName;
        private string secondName;
        private string lastName;
        private decimal balance;
        private readonly string IBAN;

        public Account(string id)
        {
            this.id = id;
            IBAN = GenerateIBAN();
        }

        private string GenerateIBAN()
        {
            return null;
        }

        public decimal WithdrawMoney(decimal amount)
        {
            if (amount <= balance - 5)
            {
                balance -= amount;
                return amount;
            }
            else
            {
                throw new ArgumentException("Not enough money in the account");
            }
        }

        public void DepositMoney(decimal amount)
        {
            balance += amount;
        }
    }
}
