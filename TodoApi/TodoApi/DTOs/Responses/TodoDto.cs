using TodoApi.Entities;

namespace TodoApi.DTOs.Responses
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }

        public static TodoDto FromEntity(Todo entity) =>
            new TodoDto()
            {
                Id = entity.Id,
                Description = entity.Description,
                CreateAt = entity.CreateAt
            };
    }
}
