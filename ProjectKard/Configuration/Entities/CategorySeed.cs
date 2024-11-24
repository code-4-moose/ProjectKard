using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectKard.Domain;

namespace ProjectKard.Configuration.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Pokemon",
                    Type = "Turn Based Fighting Game"
                }
                );
        }
    }
}