namespace DesignPatterns.Structural.Composite
{
    internal class Order : Billable
    {
        protected List<Billable> _invoices = new();

        public override void Add(Billable billable) =>
            _invoices.Add(billable);

        public override decimal GetTotal()
        {
            var total = 0M;
            foreach (var invoice in _invoices)
                total += invoice.GetTotal();

            return total;
        }
    }
}
