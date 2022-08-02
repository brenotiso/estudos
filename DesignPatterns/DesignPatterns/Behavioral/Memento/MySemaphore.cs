namespace DesignPatterns.Behavioral.Memento
{
    internal class MySemaphore
    {
        private string _state;

        public MySemaphore()
        {
            _state = "Red";
        }

        public void ChangeLight()
        {
            if (_state == "Green")
                _state = "Yellow";
            else if (_state == "Yellow")
                _state = "Red";
            else
                _state = "Green";
        }

        public IMemento Save()
        {
            return new Memento(_state);
        }

        public void Restore(IMemento memento)
        {
            _state = (string)memento.GetState();
            Console.WriteLine($"Semaphore: My state has retored to: {_state}");
        }
    }
}
