namespace DesignPatterns.Creational.Prototype
{
    internal class Document : ICloneable
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Path { get; set; }
        public Person? Author { get; set; }

        public Document() { }

        public Document(Document prototype)
        {
            Name = prototype.Name;
            Description = prototype.Description;
            Path = prototype.Path;
            //Author = prototype.Author;
            Author = (Person?)prototype.Author?.Clone();
        }

        public object Clone() => new Document(this);
    }
}
