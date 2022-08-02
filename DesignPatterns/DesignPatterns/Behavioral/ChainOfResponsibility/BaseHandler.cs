namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class BaseHandler : IHandler
    {
        private IHandler? _nextHandler = null;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Retornar o handler aqui ajuda a montar a cadeia. Exemplo:
            // handler1.SetNext(handler2).SetNext(handler3);
            return handler;
        }

        public virtual void Handle(object request)
        {
            if (_nextHandler is null)
                return;

            _nextHandler.Handle(request);
        }
    }
}
