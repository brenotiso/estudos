namespace DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Notify(object sender, string @event);
    }
}
