using Homezz.API.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Homezz.API.Core.Models.Post
{
    public class CreatePostDTO
    {
        [Required]
        [StringLength(10,MinimumLength = 2)]
        public required string Title { get; set; }

        [Required]
        [StringLength(255,MinimumLength = 20)]
        public required string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range (1,20)]
        public int NumberOfRooms { get; set; }

        [Required]
        [Range(0,int.MaxValue)]
        public int TotalUsableArea { get; set; }

        [Required]
        [Range(0,2024)]
        public int YearOfConstruction { get; set; }

        [Required]
        public PostType PostType { get; set; }

        [Required]
        public PropertyType PropertyType { get; set; }
    }
}
