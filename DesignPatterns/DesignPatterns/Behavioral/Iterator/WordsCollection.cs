using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    internal class WordsCollection : IEnumerable
    {
        readonly List<string> _collection = new();

        bool _direction = false;

        public void ReverseDirection() =>
            _direction = !_direction;


        public List<string> GetItems() =>
            _collection;

        public void AddItem(string item) =>
            _collection.Add(item);

        public IEnumerator GetEnumerator() =>
            new AlphabeticalOrderIterator(this, _direction);
    }
}
