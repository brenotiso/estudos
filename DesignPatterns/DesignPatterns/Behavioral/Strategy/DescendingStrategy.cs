namespace DesignPatterns.Behavioral.Strategy
{
    internal class DescendingStrategy : ISortStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> list)
        {
            return list.OrderBy(x => -1 * x);
        }
    }
}
