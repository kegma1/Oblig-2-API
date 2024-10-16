using Microsoft.AspNetCore.Mvc;

public class AuthorController : Controller {
    private readonly IAuthorRepository _authorRepository;

    public AuthorController(IAuthorRepository authorRepository) {
        _authorRepository = authorRepository;
    }
}