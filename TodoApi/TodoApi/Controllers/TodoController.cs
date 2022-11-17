using Microsoft.AspNetCore.Mvc;
using TodoApi.DTOs.Requests;
using TodoApi.DTOs.Responses;
using TodoApi.Entities;
using TodoApi.Services.Interfaces;

namespace TodoApi.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/todo")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _service;
        private readonly ILogger<TodoController> _logger;

        public TodoController(ITodoService service, ILogger<TodoController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<PaginatedResponseDto<TodoDto>> GetAll([FromQuery] PaginatedRequestDto filter)
        {
            return await _service.GetAll(filter);
        }

        [HttpGet("{id}")]
        public async Task<TodoDto?> GetById(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost()]
        public async Task<TodoDto> Add(CreateTodoDto todo)
        {
            return await _service.Add(todo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}