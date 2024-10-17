namespace Homezz.API.Core.Models.Pagination
{
    public class PagedResponse<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int CurrentPage { get; set; }
        public required PaginationInfo PaginationInfo { get; set; }
    }
}
