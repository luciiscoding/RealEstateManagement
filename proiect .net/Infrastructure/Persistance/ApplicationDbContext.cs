using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            modelBuilder.Entity<Property>(
                
                    entity =>
                    {
                        entity.ToTable("Properties", "Clients");
                        entity.HasKey(e => e.Id);
                        entity.Property(e => e.Id)
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()")
                        .ValueGeneratedOnAdd();
                       

                    }
                   
                );
        }

    }
}
