namespace DesignPatterns.Behavioral.Visitor
{
    internal class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = (Employee)element;

            employee.Income *= 1.10;

            Console.WriteLine("{0} {1}'s new income: {2:C}",
                employee.GetType().Name, employee.Name,
                employee.Income);
        }
    }
}
