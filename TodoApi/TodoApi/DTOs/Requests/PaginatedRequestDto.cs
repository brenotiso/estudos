using System.ComponentModel.DataAnnotations;

namespace TodoApi.DTOs.Requests
{
    public class PaginatedRequestDto
    {
        [Range(0, 100)]
        public int PageSize { get; set; } = 10;

        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; } = 1;
    }
}
