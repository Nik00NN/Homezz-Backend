using Microsoft.AspNetCore.Identity;

namespace Homezz.API.Data.Entities
{
    public class User : IdentityUser
    {
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
