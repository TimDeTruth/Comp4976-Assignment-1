using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User>? Users { get; set; }
    public DbSet<Resolution>? Resolutions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>().Property(m => m.UserId).IsRequired();
        builder.Entity<Resolution>().Property(p => p.ResolutionId).IsRequired();

        builder.Entity<User>().ToTable("UsersTable");
        builder.Entity<Resolution>().ToTable("ResolutionsTable");

        builder.Seed();
    }


}

