namespace DesignPatterns.Behavioral.State
{
    internal class GoldState : State
    {
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            _balance = balance;
            _account = account;
            Initialize();
        }

        private void Initialize()
        {
            _interest = 0.05;
            _lowerLimit = 1000.0;
            _upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            _balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            _balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            _balance += _interest * _balance;
            StateChangeCheck();
        }
        private void StateChangeCheck()
        {
            if (_balance < 0.0)
            {
                _account.State = new RedState(this);
            }
            else if (_balance < _lowerLimit)
            {
                _account.State = new SilverState(this);
            }
        }
    }
}
