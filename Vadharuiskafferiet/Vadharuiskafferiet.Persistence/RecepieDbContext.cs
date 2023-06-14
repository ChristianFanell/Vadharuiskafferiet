using Microsoft.EntityFrameworkCore;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;
using Vadharuiskafferiet.Persistence.Entities;

namespace Vadharuiskafferiet.Persistence
{
    public class RecepieDbContext : DbContext
    {
        public RecepieDbContext(DbContextOptions options) : base(options) { }
       
        public DbSet<Recepie> Recepies { get; set; } = null!;

        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ingredient>(e => e.OwnsOne(o => o.Name).Property(p => p.Value).HasColumnName("Name"));
            builder.Entity<Recepie>(e => e.OwnsOne(o => o.Description).Property(p => p.Value).HasColumnName("Description"));
            builder.Entity<Recepie>(e => e.OwnsOne(o => o.RecepieName).Property(p => p.Value).HasColumnName("Name"));
            builder.Entity<Recepie>(e => e.OwnsOne(o => o.Steps).Property(p => p.Value).HasColumnName("Steps"));
            builder.Entity<Recepie>()
                .HasMany(e => e.Ingredients)
                .WithMany(e => e.Recepies)
                .UsingEntity<RecepieIngredientJoinTable>(
                    l => l.HasOne<Ingredient>().WithMany().HasForeignKey(e => e.IngredientId),
                    l => l.HasOne<Recepie>().WithMany().HasForeignKey(e => e.RecepieId)
                 );
        }
    }
}
