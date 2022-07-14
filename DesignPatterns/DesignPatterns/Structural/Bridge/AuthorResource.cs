namespace DesignPatterns.Structural.Bridge
{
    internal class AuthorResource : IResource
    {
        private readonly Author _author;

        public AuthorResource(Author author) => _author = author;

        public string GetComplement() =>
            $"AKA '{_author.Nickname}' from {_author.Country}";

        public string GetInfo() => _author.Biography;

        public string GetName() => _author.Name;
    }
}
