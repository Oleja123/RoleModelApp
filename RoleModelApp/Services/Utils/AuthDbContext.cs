using Microsoft.EntityFrameworkCore;

public class AuthDbContext : DbContext
{
    public DbSet<User> Users { get; set; }


    public AuthDbContext(DbContextOptions<AuthDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<User>()
            .Property(u => u.PasswordHash)
            .HasMaxLength(64);

        modelBuilder.Entity<User>()
            .Property(u => u.Salt)
            .HasMaxLength(36);

    }
}