using Homezz.API.Data.Configurations;
using Homezz.API.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Homezz.API.Data
{
    public class HomezzDbContext : IdentityDbContext<User>
    {
        public HomezzDbContext(DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
