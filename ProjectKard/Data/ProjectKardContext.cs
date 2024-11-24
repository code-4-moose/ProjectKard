using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectKard.Configuration.Entities;
using ProjectKard.Data;

namespace ProjectKard.Data
{
    public class ProjectKardContext(DbContextOptions<ProjectKardContext> options) : IdentityDbContext<ProjectKardUser>(options)
    {
        public DbSet<ProjectKard.Domain.Admin> Admin { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Buyer> Buyer { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Cards> Cards { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Category> Category { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Delivery> Delivery { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Listing> Listing { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Rating> Rating { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Seller> Seller { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CardSeed());
            builder.ApplyConfiguration(new CategorySeed());
        }
    }
}
