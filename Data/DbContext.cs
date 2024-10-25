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

        modelBuilder.Entity<Author>().HasData(new Author { Id = 1, FirstName = "John Ronald Reuel", LastName = "Tolkien" });
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The Hobbit", Year = 1937, AuthorId = 1 },
            new Book { Id = 2, Title = "The Fellowship of the Ring", Year = 1954, AuthorId = 1 },
            new Book { Id = 3, Title = "The Two Towers", Year = 1954, AuthorId = 1 },
            new Book { Id = 4, Title = "The Return of the King", Year = 1955, AuthorId = 1 },
            new Book { Id = 5, Title = "The Silmarillion", Year = 1977, AuthorId = 1 },
            new Book { Id = 6, Title = "Unfinished Tales", Year = 1980, AuthorId = 1 },
            new Book { Id = 7, Title = "The Children of Húrin", Year = 2007, AuthorId = 1 },
            new Book { Id = 8, Title = "Beren and Lúthien", Year = 2017, AuthorId = 1 },
            new Book { Id = 9, Title = "The Fall of Gondolin", Year = 2018, AuthorId = 1 },
            new Book { Id = 10, Title = "The Fall of Númenor", Year = 2022, AuthorId = 1 }
        );

        modelBuilder.Entity<Author>().HasData(new Author { Id = 2, FirstName = "Roald", LastName = "Dahl" });
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 11, Title = "The Gremlins", Year = 1943, AuthorId = 2 },
            new Book { Id = 12, Title = "Verdens største fersken", Year = 1961, AuthorId = 2 },
            new Book { Id = 13, Title = "Charlie og sjokoladefabrikken", Year = 1964, AuthorId = 2 },
            new Book { Id = 14, Title = "Den magiske fingeren", Year = 1966, AuthorId = 2 },
            new Book { Id = 15, Title = "Den fantastiske Mikkel Rev", Year = 1970, AuthorId = 2 },
            new Book { Id = 16, Title = "Charlie og den store glassheisen", Year = 1972, AuthorId = 2 },
            new Book { Id = 17, Title = "Danny og den store fasanjakten", Year = 1975, AuthorId = 2 },
            new Book { Id = 18, Title = "Den kjempestore krokodillen", Year = 1978, AuthorId = 2 },
            new Book { Id = 19, Title = "Dustene", Year = 1980, AuthorId = 2 },
            new Book { Id = 20, Title = "Georgs magiske medisin", Year = 1981, AuthorId = 2 },
            new Book { Id = 21, Title = "Ramperim og ville vers", Year = 1982, AuthorId = 2 },
            new Book { Id = 22, Title = "SVK", Year = 1982, AuthorId = 2 },
            new Book { Id = 23, Title = "Heksene", Year = 1983, AuthorId = 2 }
        );

        modelBuilder.Entity<Author>().HasData(new Author { Id = 3, FirstName = "Joanne", LastName = "Rowling" });
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 24, Title = "Harry Potter and the Philosopher's Stone", Year = 1997, AuthorId = 3 },
            new Book { Id = 25, Title = "Harry Potter and the Chamber of Secrets", Year = 1998, AuthorId = 3 },
            new Book { Id = 26, Title = "Harry Potter and Prisoner of Azkaban", Year = 1999, AuthorId = 3 },
            new Book { Id = 27, Title = "Harry Potter and the Goblet of Fire", Year = 2000, AuthorId = 3 },
            new Book { Id = 28, Title = "Harry Potter and the Order of the Phoenix", Year = 2003, AuthorId = 3 },
            new Book { Id = 29, Title = "Harry Potter and the Half-Blood Prince", Year = 2005, AuthorId = 3 },
            new Book { Id = 30, Title = "Harry Potter and the Deathly Hallows", Year = 2007, AuthorId = 3 },
            new Book { Id = 31, Title = "Fantastic Beasts and Where to Find Them", Year = 2001, AuthorId = 3 },
            new Book { Id = 32, Title = "Quidditch Through the Ages", Year = 2001, AuthorId = 3 }

        );

        modelBuilder.Entity<Author>().HasData(new Author { Id = 4, FirstName = "Sonja", LastName = "Lang" });
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 33, Title = "Toki pona. The language of good", Year = 2014, AuthorId = 4 },
            new Book { Id = 34, Title = "Toki Pona Dictionary", Year = 2021, AuthorId = 4 }
        );
    }
}
