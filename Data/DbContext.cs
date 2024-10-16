using Microsoft.EntityFrameworkCore;


public class LibraryDbContext  : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book>? Book { get; set; }
    public DbSet<Author>? Author { get; set; }
    public DbSet<Category> Category { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Author>().HasData(new Author { Id = 1, FirstName = "John", LastName = "Doe" });
    modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Title = "Example Book", Year = 2023, AuthorId = 1 });
    }
}
