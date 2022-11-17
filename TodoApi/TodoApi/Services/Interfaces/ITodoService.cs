using TodoApi.DTOs.Requests;
using TodoApi.DTOs.Responses;
using TodoApi.Entities;

namespace TodoApi.Services.Interfaces
{
    public interface ITodoService
    {
        Task<PaginatedResponseDto<TodoDto>> GetAll(PaginatedRequestDto filter);

        Task<TodoDto> GetById(int id);

        Task<TodoDto> Add(CreateTodoDto todoDto);

        Task Delete(int id);
    }
}
