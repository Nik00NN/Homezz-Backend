namespace Homezz.API.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; } 
        public int NumberOfRooms { get; set; }
        public int TotalUsableArea { get; set; }
        public int YearOfConstruction { get; set; }
        public PostType PostType { get; set; }
        public PropertyType PropertyType { get; set; }
        public DateOnly CreatedDate { get; set; }
        public DateOnly UpdatedDate { get; set; }
    }
}
