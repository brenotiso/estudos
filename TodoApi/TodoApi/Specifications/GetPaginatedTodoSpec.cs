using Ardalis.Specification;
using TodoApi.Entities;

namespace TodoApi.Specifications
{
    public class GetPaginatedTodosSpec : Specification<Todo>
    {
        public GetPaginatedTodosSpec(int pageNumber, int pagesize)
        {
            Query
                .Skip((pageNumber - 1) * pagesize)
                .Take(pagesize);
        }
    }
}