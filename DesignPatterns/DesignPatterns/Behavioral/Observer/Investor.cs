namespace DesignPatterns.Behavioral.Observer
{
    internal class Investor : IObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(ISubject stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", _name, ((Stock)stock).Symbol, ((Stock)stock).Price);
        }
    }
}
