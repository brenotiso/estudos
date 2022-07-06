namespace DesignPatterns.Prototype
{
    internal class Document : ICloneable
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Path { get; set; }
        public Author? Author { get; set; }

        public Document() { }

        public Document(Document prototype)
        {
            Name = prototype.Name;
            Description = prototype.Description;
            Path = prototype.Path;
            //Author = prototype.Author;
            Author = (Author?)prototype.Author?.Clone();
        }

        public object Clone() => new Document(this);
    }
}
