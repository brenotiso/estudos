namespace DesignPatterns.Behavioral.Memento
{
    internal class Memento : IMemento
    {
        private readonly string _name;
        private readonly DateTime _date;
        private readonly object _state;

        public Memento(object state)
        {
            _name = Guid.NewGuid().ToString();
            _date = DateTime.Now;
            _state = state;
        }

        public DateTime GetDate() =>
            _date;

        public string GetName() =>
            _name;

        public object GetState() =>
            _state;
    }
}
