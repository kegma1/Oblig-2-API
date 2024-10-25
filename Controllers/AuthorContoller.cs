using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : Controller {
    private readonly IAuthorRepository _authorRepository;

    public AuthorController(IAuthorRepository authorRepository) {
        _authorRepository = authorRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Author>> GetAuthors() {
        var authors = _authorRepository.GetAllAuthors();

        if (authors == null || !authors.Any()) {
            return NotFound();
        }

        return Ok(authors);
    }

    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Author>> GetAuthorById(int id) {
        var author = _authorRepository.GetAuthorById(id);

        if (author == null) {
            return NotFound();
        }

        return Ok(author);
    }

    [HttpPost]
    public ActionResult<Author> PostAuthor(Author author) {
        _authorRepository.AddAuthor(author);
        return CreatedAtAction(nameof(GetAuthors), new { id = author.Id }, author);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAuthor(int id, Author newAuthor) {
        if (id != newAuthor.Id) {
            return BadRequest("Mismatched author ID");
        }

        var author = _authorRepository.GetAuthorById(id);
        if (author == null) {
            return NotFound();
        }

        _authorRepository.UpdateAuthor(newAuthor);

        return CreatedAtAction(nameof(GetAuthors), new { id = author.Id }, author);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAuthor(int id) {
        var author = _authorRepository.GetAuthorById(id);
        if (author == null) {
            return NotFound();
        }

        _authorRepository.DeleteAuthor(id);

        return CreatedAtAction(nameof(GetAuthors), new { id = author.Id }, author);
    }
}