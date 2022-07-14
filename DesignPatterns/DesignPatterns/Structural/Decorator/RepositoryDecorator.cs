namespace DesignPatterns.Structural.Decorator
{
    internal abstract class RepositoryDecorator<T> : IRepository<T> where T : class
    {
        protected IRepository<T> _repository;

        public RepositoryDecorator(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual T GetById(long id)
        {
            return _repository.GetById(id);
        }
    }
}
