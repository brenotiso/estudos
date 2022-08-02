namespace DesignPatterns.Behavioral.Mediator
{
    internal class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");

            if (_mediator is not null)
                _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");

            if (_mediator is not null)
                _mediator.Notify(this, "D");
        }
    }
}
