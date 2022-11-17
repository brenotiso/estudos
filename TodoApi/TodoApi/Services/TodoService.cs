using Microsoft.Extensions.Caching.Distributed;
using TodoApi.DTOs.Requests;
using TodoApi.DTOs.Responses;
using TodoApi.Entities;
using TodoApi.Exceptions;
using TodoApi.Extensions;
using TodoApi.Repositories.Interfaces;
using TodoApi.Services.Interfaces;
using TodoApi.Specifications;

namespace TodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly IDistributedCache _cache;
        private readonly IRepository<Todo> _repository;

        public TodoService(IRepository<Todo> repository, IDistributedCache cache)
        {
            _cache = cache;
            _repository = repository;
        }

        public async Task<PaginatedResponseDto<TodoDto>> GetAll(PaginatedRequestDto filter)
        {
            var spec = new GetPaginatedTodosSpec(filter.PageNumber, filter.PageSize);
            var todos = await _repository.ListAsync(spec);
            var count = await _repository.CountAsync();

            return new PaginatedResponseDto<TodoDto>()
            {
                Data = todos.Select(t => TodoDto.FromEntity(t)),
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                Total = count
            };
        }

        public async Task<TodoDto> GetById(int id)
        {
            var todo = await GetFromDatabaseById(id);

            return TodoDto.FromEntity(todo);
        }

        public async Task<TodoDto> Add(CreateTodoDto todoDto)
        {
            var newTodo = await _repository.AddAsync(new Todo
            {
                Description = todoDto.Description
            });

            return TodoDto.FromEntity(newTodo);
        }

        public async Task Delete(int id)
        {
            var todo = await GetFromDatabaseById(id);

            await _repository.DeleteAsync(todo);

            _cache.Remove($"todo-{id}");
        }

        private async Task<Todo> GetFromDatabaseById(int id) {
            if (_cache.TryGetValue($"todo-{id}", out Todo? todo) && todo is not null)
                return todo;

            todo = await _repository.GetByIdAsync(id);

            if (todo is null)
                throw new NotFoundException("Todo not found");

            await _cache.SetAsync($"todo-{id}", todo);

            return todo;
        }
    }
}
