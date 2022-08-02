namespace DesignPatterns.Behavioral.Strategy
{
    internal class AcendingStrategy : ISortStrategy
    {
        IEnumerable<int> ISortStrategy.Sort(IEnumerable<int> list)
        {
            return list.OrderBy(x => x);
        }
    }
}
