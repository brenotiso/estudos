namespace DesignPatterns.Prototype
{
    internal class Author : ICloneable
    {
        public string? Name { get; set; }
        public string? Nickname { get; set; }

        public Author() { }

        public Author(Author prototype)
        {
            Name = prototype.Name;
            Nickname = prototype.Nickname;
        }

        public object Clone() => new Author(this);
    }
}
