namespace Homezz.API.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public required string Title { get; set; } 
        public required string Description { get; set; }
        public double Price { get; set; } 
        public int NumberOfRooms { get; set; }
        public int TotalUsableArea { get; set; }
        public int YearOfConstruction { get; set; }
        public PostType PostType { get; set; }
        public PropertyType PropertyType { get; set; }
        public DateOnly CreatedDate { get; set; }
        public DateOnly? UpdatedDate { get; set; }

        public List<Photo> Photos { get; set; } = new List<Photo>();
        public required User User { get; set; }
        public required string UserId { get; set; }
    }
}
