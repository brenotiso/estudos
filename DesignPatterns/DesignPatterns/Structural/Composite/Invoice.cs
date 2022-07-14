namespace DesignPatterns.Structural.Composite
{
    internal class Invoice : Billable
    {
        private decimal _total;

        public Invoice(decimal total)
        {
            _total = total;
        }

        public override decimal GetTotal() => _total;
    }
}
