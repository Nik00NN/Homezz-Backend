using Homezz.API.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Homezz.API.Data
{
    public class HomezzDbContext : DbContext
    {
        public HomezzDbContext(DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }
    }
}
