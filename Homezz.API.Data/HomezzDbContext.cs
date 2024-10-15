using Microsoft.EntityFrameworkCore;

namespace Homezz.API.Data
{
    public class HomezzDbContext : DbContext
    {
        public HomezzDbContext(DbContextOptions options) : base(options)
        {
           
        }
    }
}
