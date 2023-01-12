using System;


namespace AulaOO.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public String Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public Account()
        {
        }

        public void withdraw(double ammount) {
            Balance -= ammount;
        }

        public void deposit(double amount) {
            Balance += amount;
        }
    }
}
