

public class BookRepository : IBookRepository
{
    private readonly LibraryDbContext _context;

    public BookRepository (LibraryDbContext context) {
        _context = context;
    }

    public void AddBook(Book book)
    {
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
        return _context.Book.ToList();
    }

    public Book? GetBookById(int id)
    {
        return _context.Book.FirstOrDefault(b => b.Id == id);
    }

    public void UpdateBook(Book book)
    {
        _context.Book.Update(book);
        _context.SaveChanges();
    }
}