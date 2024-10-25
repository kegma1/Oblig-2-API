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

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Book newBook) {
        if (id != newBook.Id) {
            return BadRequest("Mismatched book ID");
        }

        var book = _bookRepository.GetBookById(id);
        if (book == null) {
            return NotFound();
        }

        _bookRepository.UpdateBook(newBook);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id) {
        var book = _bookRepository.GetBookById(id);
        if (book == null) {
            return NotFound();
        }

        _bookRepository.DeleteBook(id);

        return NoContent();
    }
}