using Microsoft.EntityFrameworkCore;

public class AuthorRepository : IAuthorRepository
{
    private readonly LibraryDbContext _context;

    public AuthorRepository(LibraryDbContext context) {
        _context = context;
    }

    public void AddAuthor(Author author)
    {
        _context.Author.Add(author);
        _context.SaveChanges();
    }

    public void DeleteAuthor(int id)
    {
        var author = GetAuthorById(id);

        if (author != null) {
            var booksByAuthor = _context.Book.Where(b => b.AuthorId == id).ToList();
            
            if (booksByAuthor.Any()) {
                _context.Book.RemoveRange(booksByAuthor);
            }

            _context.Author.Remove(author);

            _context.SaveChanges();
        }
    }

    public IEnumerable<Author> GetAllAuthors()
    {
        return _context.Author.ToList();
    }

    public Author GetAuthorById(int id)
    {
        return _context.Author.FirstOrDefault(a => a.Id == id);
    }

    public void UpdateAuthor(Author author)
    {
        var existingAuthor = GetAuthorById(author.Id);

        if (existingAuthor == null) {
            throw new InvalidOperationException("author not found");
        }

        existingAuthor.FirstName = author.FirstName;
        existingAuthor.LastName = author.LastName;

        _context.SaveChanges();
    }
}