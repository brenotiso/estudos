namespace DesignPatterns.Structural.Decorator
{
    internal class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(long id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
