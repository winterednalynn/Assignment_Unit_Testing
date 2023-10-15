using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing
{
    public abstract class Account
    {
        public double _balance;

        public Account(double balance)
        {
            _balance = balance;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

    }
}
