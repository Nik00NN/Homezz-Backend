using Homezz.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homezz.API.Data.Configurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure (EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.PostType).HasConversion<string>();
            builder.Property(p => p.PropertyType).HasConversion<string>();
        }
    }
}
