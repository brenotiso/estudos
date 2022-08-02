namespace DesignPatterns.Behavioral.State
{
    internal class Account
    {
        private State _state;
        private readonly string _owner;

        public Account(string owner)
        {
            _owner = owner;
            _state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return _state.Balance; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- {1}", amount, _owner);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}", State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- {1}", amount, _owner);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}\n", State.GetType().Name);
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine($"Interest Paid --- {0}", _owner);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}\n", State.GetType().Name);
        }
    }
}
