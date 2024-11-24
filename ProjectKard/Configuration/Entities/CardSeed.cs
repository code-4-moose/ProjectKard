using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectKard.Domain;

namespace ProjectKard.Configuration.Entities
{
    public class CardSeed : IEntityTypeConfiguration<Cards>
    {
        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.HasData(
                new Cards { 
                    Id = 1,
                    Name = "Charizard EX",
                    Condition = "Pristine"
                }
                );
        }
    }
}
