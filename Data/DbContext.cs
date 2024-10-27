using Microsoft.EntityFrameworkCore;


public class LibraryDbContext  : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book>? Book { get; set; }
    public DbSet<Author>? Author { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Author>().HasData(new Author { Id = 1, FirstName = "John Ronald Reuel", LastName = "Tolkien" });
        modelBuilder.Entity<Book>().HasData(
            new Book {Description = "A hobbit named Bilbo Baggins embarks on an epic adventure with dwarves to reclaim treasure guarded by a dragon.", ISBN = 9780345339683, Id = 1, Title = "The Hobbit", Year = 1937, AuthorId = 1 },
            new Book {Description = "The first book in The Lord of the Rings series, following Frodo and his companions on a journey to destroy the One Ring.", ISBN = 9780345339706, Id = 2, Title = "The Fellowship of the Ring", Year = 1954, AuthorId = 1 },
            new Book {Description = "The journey continues as the fellowship is divided, facing new perils and forging alliances against the dark forces.", ISBN = 9780345339713, Id = 3, Title = "The Two Towers", Year = 1954, AuthorId = 1 },
            new Book {Description = "The final confrontation in Middle-earth as the forces of good battle Sauron for the fate of all.", ISBN = 9780345339737, Id = 4, Title = "The Return of the King", Year = 1955, AuthorId = 1 },
            new Book {Description = "A collection of mythopoeic stories that set the background of Middle-earth, describing its creation and ancient history.", ISBN = 9780345325815, Id = 5, Title = "The Silmarillion", Year = 1977, AuthorId = 1 },
            new Book {Description = "A series of stories and essays expanding the lore and history of Middle-earth, focusing on unfinished works by Tolkien.", ISBN = 9780345357113, Id = 6, Title = "Unfinished Tales", Year = 1980, AuthorId = 1 },
            new Book {Description = "A tragic tale from Middle-earth about the heroic but doomed children of Húrin.", ISBN = 9780618894642, Id = 7, Title = "The Children of Húrin", Year = 2007, AuthorId = 1 },
            new Book {Description = "A love story between the mortal Beren and the elf Lúthien, defying impossible odds and enemies.", ISBN = 9780063376403, Id = 8, Title = "Beren and Lúthien", Year = 2017, AuthorId = 1 },
            new Book {Description = "Chronicles the tragic fall of Gondolin, an elven city besieged by Morgoth.", ISBN = 9780008503970, Id = 9, Title = "The Fall of Gondolin", Year = 2018, AuthorId = 1 },
            new Book {Description = "Explores the ancient, powerful island kingdom of Númenor and its eventual downfall.", ISBN = 9780008655679, Id = 10, Title = "The Fall of Númenor", Year = 2022, AuthorId = 1 }
        );

        modelBuilder.Entity<Author>().HasData(new Author { Id = 2, FirstName = "Roald", LastName = "Dahl" });
        modelBuilder.Entity<Book>().HasData(
            new Book {Description = "A young boy escapes on a giant peach, encountering strange creatures and unexpected adventures.", ISBN = 9780451480798, Id = 12, Title = "Verdens største fersken", Year = 1961, AuthorId = 2 },
            new Book {Description = "A poor boy wins a tour of a magical chocolate factory owned by the eccentric Willy Wonka.", ISBN = 9780142410318, Id = 13, Title = "Charlie og sjokoladefabrikken", Year = 1964, AuthorId = 2 },
            new Book {Description = "A girl with a magic finger can change people’s lives when she gets angry.", ISBN = 9780142413852, Id = 14, Title = "Den magiske fingeren", Year = 1966, AuthorId = 2 },
            new Book {Description = "A clever fox outwits farmers in this witty story about survival and resourcefulness.", ISBN = 9780142410349, Id = 15, Title = "Den fantastiske Mikkel Rev", Year = 1970, AuthorId = 2 },
            new Book {Description = "Charlie and his family embark on a wild space adventure in a magical glass elevator.", ISBN = 9780142410325, Id = 16, Title = "Charlie og den store glassheisen", Year = 1972, AuthorId = 2 },
            new Book {Description = "A boy and his father plan a grand pheasant-catching scheme against a wealthy landowner.", ISBN = 9780142410332, Id = 17, Title = "Danny og den store fasanjakten", Year = 1975, AuthorId = 2 },
            new Book {Description = "A crocodile hatches cunning plans to catch children for dinner, only to be thwarted.", ISBN = 9780140365566, Id = 18, Title = "Den kjempestore krokodillen", Year = 1978, AuthorId = 2 },
            new Book {Description = "A comical story about a very unpleasant couple who play nasty tricks on each other.", ISBN = 9780142410394, Id = 19, Title = "Dustene", Year = 1980, AuthorId = 2 },
            new Book {Description = "George concocts a magical medicine to deal with his nasty grandmother, with hilarious results.", ISBN = 9780142410356, Id = 20, Title = "Georgs magiske medisin", Year = 1981, AuthorId = 2 },
            new Book {Description = "A collection of whimsical and darkly humorous rhymes for children.", ISBN = 9780141369327, Id = 21, Title = "Ramperim og ville vers", Year = 1982, AuthorId = 2 },
            new Book {Description = "The Big Friendly Giant befriends a young girl, and together they battle evil giants.", ISBN = 9780142410387, Id = 22, Title = "SVK", Year = 1982, AuthorId = 2 },
            new Book {Description = "A boy discovers the sinister world of witches and their plans to rid the world of children.", ISBN = 9781101996997, Id = 23, Title = "Heksene", Year = 1983, AuthorId = 2 }
        );

        modelBuilder.Entity<Author>().HasData(new Author { Id = 3, FirstName = "Joanne", LastName = "Rowling" });
        modelBuilder.Entity<Book>().HasData(
            new Book {Description = "A young boy discovers he’s a wizard and attends Hogwarts, where he faces magical adventures and dangers.", ISBN = 9781551923987, Id = 24, Title = "Harry Potter and the Philosopher's Stone", Year = 1997, AuthorId = 3 },
            new Book {Description = "Harry returns to Hogwarts and unravels the mystery of a deadly chamber hidden in the school.", ISBN = 9780439064873, Id = 25, Title = "Harry Potter and the Chamber of Secrets", Year = 1998, AuthorId = 3 },
            new Book {Description = "Harry learns of a fugitive, Sirius Black, and the secrets of his own past.", ISBN = 9780439136365, Id = 26, Title = "Harry Potter and Prisoner of Azkaban", Year = 1999, AuthorId = 3 },
            new Book {Description = "Harry is unwillingly entered into a magical tournament that brings danger to his life.", ISBN = 9780439139601, Id = 27, Title = "Harry Potter and the Goblet of Fire", Year = 2000, AuthorId = 3 },
            new Book {Description = "Harry faces increased threats and challenges as he fights the dark forces gathering in the wizarding world.", ISBN = 9780439358071, Id = 28, Title = "Harry Potter and the Order of the Phoenix", Year = 2003, AuthorId = 3 },
            new Book {Description = "Dark secrets of Voldemort’s past are uncovered, setting up a final battle.", ISBN = 9780439785969, Id = 29, Title = "Harry Potter and the Half-Blood Prince", Year = 2005, AuthorId = 3 },
            new Book {Description = "Harry and his friends embark on a quest to defeat Voldemort and save the wizarding world.", ISBN = 9780545010221, Id = 30, Title = "Harry Potter and the Deathly Hallows", Year = 2007, AuthorId = 3 },
            new Book {Description = "A guide to magical creatures in the wizarding world, written by Newt Scamander.", ISBN = 9781408803011, Id = 31, Title = "Fantastic Beasts and Where to Find Them", Year = 2001, AuthorId = 3 },
            new Book {Description = "A comprehensive history of Quidditch, the wizarding sport beloved by witches and wizards alike.", ISBN = 9788498387926, Id = 32, Title = "Quidditch Through the Ages", Year = 2001, AuthorId = 3 }

        );

        modelBuilder.Entity<Author>().HasData(new Author { Id = 4, FirstName = "Sonja", LastName = "Lang" });
        modelBuilder.Entity<Book>().HasData(
            new Book {Description = "An introduction to the minimalist constructed language, Toki Pona, focused on simplicity and positivity.", ISBN = 9780978292300, Id = 33, Title = "Toki pona. The language of good", Year = 2014, AuthorId = 4 },
            new Book {Description = "A comprehensive dictionary for Toki Pona, detailing vocabulary and usage for language learners.", ISBN = 9780978292362, Id = 34, Title = "Toki Pona Dictionary", Year = 2021, AuthorId = 4 }
        );
    }
}
