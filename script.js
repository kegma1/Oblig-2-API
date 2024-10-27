$(document).ready(function() {
    const urlParams = new URLSearchParams(window.location.search);
    const authorId = urlParams.get("author");
    loadBooks(authorId);

    function loadBooks(authorId = null) {
        const url = authorId ? `http://localhost:5115/api/Book/Author/${authorId}` : "http://localhost:5115/api/Book";
        
        $.ajax({
            url: url,
            type: "GET",
            success: function(books) {
                let html = "";
                books.forEach(book => {
                    html += `
                        <div class="book">
                            <div class="book-info">
                                <h2>${book.title}</h2>
                                <p class="description">${book.description}</p>
                                <p>Year of release: ${book.year}</p>
                                <a href="?author=${book.author.id}">By: ${book.author.firstName} ${book.author.lastName}</a>
                                
                                <div class="book-options"> 
                                    <button type="button" id="delete-book" onclick="deleteBook(${book.id})">Delete</button> 
                                </div>
                            </div>
                            <img class="book-cover" src="https://pictures.abebooks.com/isbn/${book.isbn}-us.jpg" alt="cover of ${book.title}">
                        </div>
                    `;
                });
                $("#book-list").html(html);
            },
            error: function() {
                if (authorId) {
                    window.location.href = "/"
                }
                alert("Something went wrong while loading");
            }
        });
    }
});

function deleteBook(id) {
    $.ajax({
        url: "http://localhost:5115/api/Book/" + id,
        type: "DELETE",
        success: function(_) {
            location.reload()
        }
    })
}
