namespace DesignPatterns.Structural.Composite
{
    internal class Negociation : Billable
    {
        protected List<Billable> _orders = new();

        public override void Add(Billable billable) =>
            _orders.Add(billable);

        public override decimal GetTotal()
        {
            var total = 0M;
            foreach (var order in _orders)
                total += order.GetTotal();

            return total;
        }
    }
}
