﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Oblig_2_API.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.35");

            modelBuilder.Entity("Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John Ronald Reuel",
                            LastName = "Tolkien"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Roald",
                            LastName = "Dahl"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Joanne",
                            LastName = "Rowling"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Sonja",
                            LastName = "Lang"
                        });
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ISBN")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "A hobbit named Bilbo Baggins embarks on an epic adventure with dwarves to reclaim treasure guarded by a dragon.",
                            ISBN = 9780345339683L,
                            Title = "The Hobbit",
                            Year = 1937
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "The first book in The Lord of the Rings series, following Frodo and his companions on a journey to destroy the One Ring.",
                            ISBN = 9780345339706L,
                            Title = "The Fellowship of the Ring",
                            Year = 1954
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Description = "The journey continues as the fellowship is divided, facing new perils and forging alliances against the dark forces.",
                            ISBN = 9780345339713L,
                            Title = "The Two Towers",
                            Year = 1954
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Description = "The final confrontation in Middle-earth as the forces of good battle Sauron for the fate of all.",
                            ISBN = 9780345339737L,
                            Title = "The Return of the King",
                            Year = 1955
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Description = "A collection of mythopoeic stories that set the background of Middle-earth, describing its creation and ancient history.",
                            ISBN = 9780345325815L,
                            Title = "The Silmarillion",
                            Year = 1977
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            Description = "A series of stories and essays expanding the lore and history of Middle-earth, focusing on unfinished works by Tolkien.",
                            ISBN = 9780345357113L,
                            Title = "Unfinished Tales",
                            Year = 1980
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 1,
                            Description = "A tragic tale from Middle-earth about the heroic but doomed children of Húrin.",
                            ISBN = 9780618894642L,
                            Title = "The Children of Húrin",
                            Year = 2007
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 1,
                            Description = "A love story between the mortal Beren and the elf Lúthien, defying impossible odds and enemies.",
                            ISBN = 9780063376403L,
                            Title = "Beren and Lúthien",
                            Year = 2017
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 1,
                            Description = "Chronicles the tragic fall of Gondolin, an elven city besieged by Morgoth.",
                            ISBN = 9780008503970L,
                            Title = "The Fall of Gondolin",
                            Year = 2018
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 1,
                            Description = "Explores the ancient, powerful island kingdom of Númenor and its eventual downfall.",
                            ISBN = 9780008655679L,
                            Title = "The Fall of Númenor",
                            Year = 2022
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 2,
                            Description = "A young boy escapes on a giant peach, encountering strange creatures and unexpected adventures.",
                            ISBN = 9780451480798L,
                            Title = "Verdens største fersken",
                            Year = 1961
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 2,
                            Description = "A poor boy wins a tour of a magical chocolate factory owned by the eccentric Willy Wonka.",
                            ISBN = 9780142410318L,
                            Title = "Charlie og sjokoladefabrikken",
                            Year = 1964
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 2,
                            Description = "A girl with a magic finger can change people’s lives when she gets angry.",
                            ISBN = 9780142413852L,
                            Title = "Den magiske fingeren",
                            Year = 1966
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 2,
                            Description = "A clever fox outwits farmers in this witty story about survival and resourcefulness.",
                            ISBN = 9780142410349L,
                            Title = "Den fantastiske Mikkel Rev",
                            Year = 1970
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 2,
                            Description = "Charlie and his family embark on a wild space adventure in a magical glass elevator.",
                            ISBN = 9780142410325L,
                            Title = "Charlie og den store glassheisen",
                            Year = 1972
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 2,
                            Description = "A boy and his father plan a grand pheasant-catching scheme against a wealthy landowner.",
                            ISBN = 9780142410332L,
                            Title = "Danny og den store fasanjakten",
                            Year = 1975
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 2,
                            Description = "A crocodile hatches cunning plans to catch children for dinner, only to be thwarted.",
                            ISBN = 9780140365566L,
                            Title = "Den kjempestore krokodillen",
                            Year = 1978
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 2,
                            Description = "A comical story about a very unpleasant couple who play nasty tricks on each other.",
                            ISBN = 9780142410394L,
                            Title = "Dustene",
                            Year = 1980
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 2,
                            Description = "George concocts a magical medicine to deal with his nasty grandmother, with hilarious results.",
                            ISBN = 9780142410356L,
                            Title = "Georgs magiske medisin",
                            Year = 1981
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = 2,
                            Description = "A collection of whimsical and darkly humorous rhymes for children.",
                            ISBN = 9780141369327L,
                            Title = "Ramperim og ville vers",
                            Year = 1982
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = 2,
                            Description = "The Big Friendly Giant befriends a young girl, and together they battle evil giants.",
                            ISBN = 9780142410387L,
                            Title = "SVK",
                            Year = 1982
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = 2,
                            Description = "A boy discovers the sinister world of witches and their plans to rid the world of children.",
                            ISBN = 9781101996997L,
                            Title = "Heksene",
                            Year = 1983
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = 3,
                            Description = "A young boy discovers he’s a wizard and attends Hogwarts, where he faces magical adventures and dangers.",
                            ISBN = 9781551923987L,
                            Title = "Harry Potter and the Philosopher's Stone",
                            Year = 1997
                        },
                        new
                        {
                            Id = 25,
                            AuthorId = 3,
                            Description = "Harry returns to Hogwarts and unravels the mystery of a deadly chamber hidden in the school.",
                            ISBN = 9780439064873L,
                            Title = "Harry Potter and the Chamber of Secrets",
                            Year = 1998
                        },
                        new
                        {
                            Id = 26,
                            AuthorId = 3,
                            Description = "Harry learns of a fugitive, Sirius Black, and the secrets of his own past.",
                            ISBN = 9780439136365L,
                            Title = "Harry Potter and Prisoner of Azkaban",
                            Year = 1999
                        },
                        new
                        {
                            Id = 27,
                            AuthorId = 3,
                            Description = "Harry is unwillingly entered into a magical tournament that brings danger to his life.",
                            ISBN = 9780439139601L,
                            Title = "Harry Potter and the Goblet of Fire",
                            Year = 2000
                        },
                        new
                        {
                            Id = 28,
                            AuthorId = 3,
                            Description = "Harry faces increased threats and challenges as he fights the dark forces gathering in the wizarding world.",
                            ISBN = 9780439358071L,
                            Title = "Harry Potter and the Order of the Phoenix",
                            Year = 2003
                        },
                        new
                        {
                            Id = 29,
                            AuthorId = 3,
                            Description = "Dark secrets of Voldemort’s past are uncovered, setting up a final battle.",
                            ISBN = 9780439785969L,
                            Title = "Harry Potter and the Half-Blood Prince",
                            Year = 2005
                        },
                        new
                        {
                            Id = 30,
                            AuthorId = 3,
                            Description = "Harry and his friends embark on a quest to defeat Voldemort and save the wizarding world.",
                            ISBN = 9780545010221L,
                            Title = "Harry Potter and the Deathly Hallows",
                            Year = 2007
                        },
                        new
                        {
                            Id = 31,
                            AuthorId = 3,
                            Description = "A guide to magical creatures in the wizarding world, written by Newt Scamander.",
                            ISBN = 9781408803011L,
                            Title = "Fantastic Beasts and Where to Find Them",
                            Year = 2001
                        },
                        new
                        {
                            Id = 32,
                            AuthorId = 3,
                            Description = "A comprehensive history of Quidditch, the wizarding sport beloved by witches and wizards alike.",
                            ISBN = 9788498387926L,
                            Title = "Quidditch Through the Ages",
                            Year = 2001
                        },
                        new
                        {
                            Id = 33,
                            AuthorId = 4,
                            Description = "An introduction to the minimalist constructed language, Toki Pona, focused on simplicity and positivity.",
                            ISBN = 9780978292300L,
                            Title = "Toki pona. The language of good",
                            Year = 2014
                        },
                        new
                        {
                            Id = 34,
                            AuthorId = 4,
                            Description = "A comprehensive dictionary for Toki Pona, detailing vocabulary and usage for language learners.",
                            ISBN = 9780978292362L,
                            Title = "Toki Pona Dictionary",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.HasOne("Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
