namespace DesignPatterns.Behavioral.Mediator
{
    internal class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");

            if (_mediator is not null)
                _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");

            if (_mediator is not null)
                _mediator.Notify(this, "B");
        }
    }
}
