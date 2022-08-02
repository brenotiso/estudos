namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class AuthorizationHandler : BaseHandler
    {
        public override void Handle(object request)
        {
            // realiza a autorização
            Console.WriteLine($"AuthorizationHandler: {request}");

            base.Handle(request);
        }
    }
}
