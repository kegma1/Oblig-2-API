$(document).ready(function() {
    $.ajax({
        url: "http://localhost:5115/api/Book",
        type: "GET",
        success: function(books) {
            let html = "";
            books.forEach(book => {
                html += `
                    <div>
                        <h2>${book.title}</h2>
                        <p>${book.description}</p>
                        <p>${book.year}</p>
                        <p>By: ${book.author.firstName} ${book.author.lastName}</p>
                    </div>
                `;
            });
            $("#book-list").html(html)
        },
        error: function() {
            alert("Something went wrong while loading")
        }
    })
})