using ProjectAccount.Entities.Exceptions;
namespace ProjectAccount.Entities

{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw (double amount)
        {
            if(amount > WithDrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            else if(amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }
            Balance -= amount;
        }

    }
}