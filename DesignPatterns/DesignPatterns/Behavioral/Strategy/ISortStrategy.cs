namespace DesignPatterns.Behavioral.Strategy
{
    internal interface ISortStrategy
    {
        IEnumerable<int> Sort(IEnumerable<int> list);
    }
}
