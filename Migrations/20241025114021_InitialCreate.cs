using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oblig_2_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "John Ronald Reuel", "Tolkien" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Roald", "Dahl" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Joanne", "Rowling" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 4, "Sonja", "Lang" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 1, 1, null, "", "The Hobbit", 1937 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 2, 1, null, "", "The Fellowship of the Ring", 1954 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 3, 1, null, "", "The Two Towers", 1954 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 4, 1, null, "", "The Return of the King", 1955 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 5, 1, null, "", "The Silmarillion", 1977 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 6, 1, null, "", "Unfinished Tales", 1980 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 7, 1, null, "", "The Children of Húrin", 2007 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 8, 1, null, "", "Beren and Lúthien", 2017 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 9, 1, null, "", "The Fall of Gondolin", 2018 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 10, 1, null, "", "The Fall of Númenor", 2022 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 11, 2, null, "", "The Gremlins", 1943 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 12, 2, null, "", "Verdens største fersken", 1961 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 13, 2, null, "", "Charlie og sjokoladefabrikken", 1964 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 14, 2, null, "", "Den magiske fingeren", 1966 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 15, 2, null, "", "Den fantastiske Mikkel Rev", 1970 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 16, 2, null, "", "Charlie og den store glassheisen", 1972 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 17, 2, null, "", "Danny og den store fasanjakten", 1975 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 18, 2, null, "", "Den kjempestore krokodillen", 1978 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 19, 2, null, "", "Dustene", 1980 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 20, 2, null, "", "Georgs magiske medisin", 1981 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 21, 2, null, "", "Ramperim og ville vers", 1982 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 22, 2, null, "", "SVK", 1982 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 23, 2, null, "", "Heksene", 1983 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 24, 3, null, "", "Harry Potter and the Philosopher's Stone", 1997 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 25, 3, null, "", "Harry Potter and the Chamber of Secrets", 1998 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 26, 3, null, "", "Harry Potter and Prisoner of Azkaban", 1999 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 27, 3, null, "", "Harry Potter and the Goblet of Fire", 2000 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 28, 3, null, "", "Harry Potter and the Order of the Phoenix", 2003 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 29, 3, null, "", "Harry Potter and the Half-Blood Prince", 2005 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 30, 3, null, "", "Harry Potter and the Deathly Hallows", 2007 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 31, 3, null, "", "Fantastic Beasts and Where to Find Them", 2001 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 32, 3, null, "", "Quidditch Through the Ages", 2001 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 33, 4, null, "", "Toki pona. The language of good", 2014 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "Year" },
                values: new object[] { 34, 4, null, "", "Toki Pona Dictionary", 2021 });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
