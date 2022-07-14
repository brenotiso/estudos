using System.Diagnostics;

namespace DesignPatterns.Structural.Decorator
{
    internal class RepositoryLoggerDecorator<T> : RepositoryDecorator<T> where T : class
    {
        public RepositoryLoggerDecorator(IRepository<T> repository) : base(repository)
        {
        }

        public override T GetById(long id)
        {
            Console.WriteLine("Searching for {0} with Id = {1}", typeof(T), id);

            var stopwatch = Stopwatch.StartNew();

            var result = _repository.GetById(id);

            stopwatch.Stop();

            var elapsedTime = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("Finished fetching data in {0} milliseconds", elapsedTime);

            return result;
        }
    }
}
