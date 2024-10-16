public class AuthorRepository : IAuthorRepository
{
    private readonly LibraryDbContext _context;

    public AuthorRepository(LibraryDbContext context) {
        _context = context;
    }

    public void AddAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    public void DeleteAuthor(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Author> GetAllAuthors()
    {
        throw new NotImplementedException();
    }

    public Author GetAuthorById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateAuthor(Author author)
    {
        throw new NotImplementedException();
    }
}