namespace DesignPatterns.Behavioral.Memento
{
    internal class MySemaphoreCaretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private MySemaphore _originator;

        public MySemaphoreCaretaker(MySemaphore originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos)
                Console.WriteLine($"{memento.GetName()} - {memento.GetDate().Ticks}");
        }
    }
}
