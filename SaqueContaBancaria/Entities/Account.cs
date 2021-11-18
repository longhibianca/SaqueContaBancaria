using SaqueContaBancaria.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaqueContaBancaria.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance <= amount)
            {
                throw new DomainException("Not enought balance");
            }
            Balance = Balance - amount;
        }
    }
}
