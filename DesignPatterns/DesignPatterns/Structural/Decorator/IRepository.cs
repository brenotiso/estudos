namespace DesignPatterns.Structural.Decorator
{
    internal interface IRepository<T> where T : class
    {
        T GetById(long id);
    }
}
