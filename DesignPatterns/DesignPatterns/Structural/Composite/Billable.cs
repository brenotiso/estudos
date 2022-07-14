namespace DesignPatterns.Structural.Composite
{
    internal abstract class Billable
    {
        public virtual void Add(Billable billable) =>
            throw new NotImplementedException();

        public abstract decimal GetTotal();
    }
}
