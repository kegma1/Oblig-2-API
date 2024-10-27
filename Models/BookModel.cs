public class Book {
    public int Id { get; set; } 
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public long ISBN { get; set; }
    public int Year { get; set; } 
    public int AuthorId { get; set; }
    public Author? Author { get; set; } 
}
