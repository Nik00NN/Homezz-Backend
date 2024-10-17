namespace Homezz.API.Data.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public required string FileName { get; set; }
        public required byte[] PhotoContent { get; set; }

        public required Post Post { get; set; }
        public int PostId { get; set; }
    }
}
