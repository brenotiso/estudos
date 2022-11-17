namespace TodoApi.DTOs.Responses
{
    public class PaginatedResponseDto<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int Total { get; set; }
    }
}
