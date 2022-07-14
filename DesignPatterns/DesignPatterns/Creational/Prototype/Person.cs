namespace DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public string? Name { get; set; }
        public string? Nickname { get; set; }

        public Person() { }

        public Person(Person prototype)
        {
            Name = prototype.Name;
            Nickname = prototype.Nickname;
        }

        public object Clone() => new Person(this);
    }
}
