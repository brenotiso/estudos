using System.ComponentModel.DataAnnotations;

namespace TodoApi.DTOs.Requests
{
    public class CreateTodoDto
    {
        [Required]
        public string Description { get; set; }
    }
}
