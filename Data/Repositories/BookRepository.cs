using Microsoft.EntityFrameworkCore;

public class BookRepository : IBookRepository
{
    private readonly LibraryDbContext _context;

    public BookRepository (LibraryDbContext context) {
        _context = context;
    }

    public void AddBook(Book book)
    {
        if (book.Author != null) {
            _context.Author.Attach(book.Author);
        }

        _context.Book.Add(book);
        _context.SaveChanges();
    }

    public void DeleteBook(int id)
    {
       var book = GetBookById(id);

       if (book != null) {
        _context.Book.Remove(book);
        _context.SaveChanges();
       }
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _context.Book.Include(b => b.Author).ToList();
    }

    public IEnumerable<Book> GetBooksByAuthorId(int id) {
        return _context.Book.Where(b => b.AuthorId == id).ToList();
    }

    public Book? GetBookById(int id)
    {
        return _context.Book.Include(b => b.Author).FirstOrDefault(b => b.Id == id);
    }

    public void UpdateBook(Book book)
    {
        var existingBook = GetBookById(book.Id);

        if (existingBook == null) {
            throw new InvalidOperationException("book not found");
        }

        existingBook.Title = book.Title;
        existingBook.Description = book.Description;
        existingBook.Year = book.Year;

        if (existingBook.AuthorId != book.AuthorId) {
            var newAuthor = _context.Author.Find(book.AuthorId);
            if (newAuthor != null) {
                existingBook.Author = newAuthor;
                existingBook.AuthorId = book.AuthorId;
            }
        }
        
        _context.SaveChanges();
    }
}