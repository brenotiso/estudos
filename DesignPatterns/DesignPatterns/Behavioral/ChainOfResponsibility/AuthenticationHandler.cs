namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class AuthenticationHandler : BaseHandler
    {
        public override void Handle(object request)
        {
            // realiza a autenticação
            Console.WriteLine($"AuthenticationHandler: {request}");

            base.Handle(request);
        }
    }
}
