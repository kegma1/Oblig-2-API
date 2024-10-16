using Microsoft.AspNetCore.Mvc;

public class BookController : Controller {
    private readonly IBookRepository _bookRepository;

    public BookController(IBookRepository bookRepository) {
        _bookRepository = bookRepository;
    }
}