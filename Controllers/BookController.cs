using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller {
    private readonly IBookRepository _bookRepository;

    public BookController(IBookRepository bookRepository) {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks() {
        var books = _bookRepository.GetAllBooks();

        if (books == null || !books.Any())
        {
            return NotFound();
        }

        return Ok(books);
    }

    [HttpPost]
    public ActionResult<Book> PostBook(Book book) {
        _bookRepository.AddBook(book);
        return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
    }
}