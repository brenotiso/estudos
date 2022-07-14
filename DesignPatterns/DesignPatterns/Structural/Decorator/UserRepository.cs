namespace DesignPatterns.Structural.Decorator
{
    internal class UserRepository : IRepository<User>
    {
        public User GetById(long id)
        {
            return new User(1, "Jhon", "jhon@jj.com");
        }
    }
}
