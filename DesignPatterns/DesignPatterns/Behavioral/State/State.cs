namespace DesignPatterns.Behavioral.State
{
    internal abstract class State
    {
        protected Account _account;
        protected double _balance;
        protected double _interest;
        protected double _lowerLimit;
        protected double _upperLimit;

        public Account Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

        public abstract void PayInterest();
    }
}
