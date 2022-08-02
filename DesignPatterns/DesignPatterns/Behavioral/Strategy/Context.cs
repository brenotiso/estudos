namespace DesignPatterns.Behavioral.Strategy
{
    internal class Context
    {
        private ISortStrategy? _strategy;

        public Context()
        { }

        public Context(ISortStrategy strategy)
        {
            _strategy = strategy;
        }


        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            if (_strategy == null)
                throw new NullReferenceException();

            Console.WriteLine("Context: Sorting data using the strategy");
            var result = _strategy.Sort(new List<int> { 2, 4, 1, 3, 5 });

            var resultStr = String.Empty;
            foreach (var element in result)
                resultStr += element + ";";

            Console.WriteLine(resultStr);
        }
    }
}
