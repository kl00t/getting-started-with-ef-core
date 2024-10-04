using Microsoft.EntityFrameworkCore;
using Movies.Api.Movies;

namespace Movies.Api.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=mydb;User ID=workshop;Password=changeme;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasIndex(x => x.YearOfRelease);
    }

    public DbSet<Movie> Movies { get; set; }
}
