namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);

        void Handle(object request);
    }
}
