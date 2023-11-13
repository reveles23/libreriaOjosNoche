const tbody = document.getElementById('tbody');
const searchTitleInput = document.getElementById('searchTitle');

fetchBooks();

//! Acción del botón de búsqueda por título
function searchBooks() {
    const searchTitle = searchTitleInput.value.trim().toLowerCase();

    if (searchTitle !== "") {
        while (tbody.firstChild) { tbody.removeChild(tbody.firstChild); }
        getBooksByTitle(searchTitle);
    } else {
        alert("Por favor inserta un título para buscar.");
    }
}

function fetchBooks(){
    //!Fetch get (get books with authors)
    fetch('http://localhost:5134/api/LibroAutor')
            .then(LibroAutor => LibroAutor.json())
            .then(LibroAutor => insertInTable(LibroAutor));
}

function getBooksByTitle(title) {
    // Convierte la cadena de búsqueda a minúsculas para una comparación sin distinción de mayúsculas
    const searchTitleLowerCase = title.toLowerCase();

    //! Fetch get (get books by title)
    fetch(`http://localhost:5134/api/LibroAutor`)
        .then(response => response.json())
        .then(libros => {
            const filteredBooks = libros.filter(libro => libro.tituloLibro.toLowerCase().includes(searchTitleLowerCase));
            insertInTable(filteredBooks);
        });
}

//! Inserta los datos correspondientes a partir de un const = () => {}; Para todos los libros
const insertInTable = (LibroAutor) => {
    
    for(i = 0; i< LibroAutor.length; i++){
        htmlCode = '<tr>'+
                        "<td>" + LibroAutor[i].tituloLibro + "</td>" +
                        "<td>" + LibroAutor[i].autorLibro + "</td>" +
                        "<td>" + LibroAutor[i].capitulosLibro + "</td>" +
                        "<td>" + LibroAutor[i].paginasLibro + "</td>" +
                        "<td> $ " + LibroAutor[i].precioLibro + "</td>" +
                    "</tr>";
        tbody.insertAdjacentHTML("beforeend", htmlCode);
        htmlCode = "";
    } 
};