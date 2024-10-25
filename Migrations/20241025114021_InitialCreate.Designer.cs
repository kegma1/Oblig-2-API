﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Oblig_2_API.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20241025114021_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Hobbit",
                            Year = 1937
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Fellowship of the Ring",
                            Year = 1954
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Two Towers",
                            Year = 1954
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Return of the King",
                            Year = 1955
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Silmarillion",
                            Year = 1977
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            Description = "",
                            Title = "Unfinished Tales",
                            Year = 1980
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Children of Húrin",
                            Year = 2007
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 1,
                            Description = "",
                            Title = "Beren and Lúthien",
                            Year = 2017
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Fall of Gondolin",
                            Year = 2018
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 1,
                            Description = "",
                            Title = "The Fall of Númenor",
                            Year = 2022
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 2,
                            Description = "",
                            Title = "The Gremlins",
                            Year = 1943
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 2,
                            Description = "",
                            Title = "Verdens største fersken",
                            Year = 1961
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 2,
                            Description = "",
                            Title = "Charlie og sjokoladefabrikken",
                            Year = 1964
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 2,
                            Description = "",
                            Title = "Den magiske fingeren",
                            Year = 1966
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 2,
                            Description = "",
                            Title = "Den fantastiske Mikkel Rev",
                            Year = 1970
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 2,
                            Description = "",
                            Title = "Charlie og den store glassheisen",
                            Year = 1972
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 2,
                            Description = "",
                            Title = "Danny og den store fasanjakten",
                            Year = 1975
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 2,
                            Description = "",
                            Title = "Den kjempestore krokodillen",
                            Year = 1978
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 2,
                            Description = "",
                            Title = "Dustene",
                            Year = 1980
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 2,
                            Description = "",
                            Title = "Georgs magiske medisin",
                            Year = 1981
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = 2,
                            Description = "",
                            Title = "Ramperim og ville vers",
                            Year = 1982
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = 2,
                            Description = "",
                            Title = "SVK",
                            Year = 1982
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = 2,
                            Description = "",
                            Title = "Heksene",
                            Year = 1983
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and the Philosopher's Stone",
                            Year = 1997
                        },
                        new
                        {
                            Id = 25,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and the Chamber of Secrets",
                            Year = 1998
                        },
                        new
                        {
                            Id = 26,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and Prisoner of Azkaban",
                            Year = 1999
                        },
                        new
                        {
                            Id = 27,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and the Goblet of Fire",
                            Year = 2000
                        },
                        new
                        {
                            Id = 28,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and the Order of the Phoenix",
                            Year = 2003
                        },
                        new
                        {
                            Id = 29,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and the Half-Blood Prince",
                            Year = 2005
                        },
                        new
                        {
                            Id = 30,
                            AuthorId = 3,
                            Description = "",
                            Title = "Harry Potter and the Deathly Hallows",
                            Year = 2007
                        },
                        new
                        {
                            Id = 31,
                            AuthorId = 3,
                            Description = "",
                            Title = "Fantastic Beasts and Where to Find Them",
                            Year = 2001
                        },
                        new
                        {
                            Id = 32,
                            AuthorId = 3,
                            Description = "",
                            Title = "Quidditch Through the Ages",
                            Year = 2001
                        },
                        new
                        {
                            Id = 33,
                            AuthorId = 4,
                            Description = "",
                            Title = "Toki pona. The language of good",
                            Year = 2014
                        },
                        new
                        {
                            Id = 34,
                            AuthorId = 4,
                            Description = "",
                            Title = "Toki Pona Dictionary",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.HasOne("Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Category", null)
                        .WithMany("Books")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}