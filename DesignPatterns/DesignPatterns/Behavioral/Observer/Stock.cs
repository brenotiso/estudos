namespace DesignPatterns.Behavioral.Observer
{
    internal class Stock : ISubject
    {
        private string _symbol;
        private double _price;
        private List<IObserver> _investors = new List<IObserver>();

        public Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }
        public void Attach(IObserver investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IObserver investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IObserver investor in _investors)
                investor.Update(this);
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}
