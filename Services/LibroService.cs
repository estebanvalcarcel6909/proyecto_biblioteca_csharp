
using system_books.Models;

namespace system_books.Services
{
    public class LibroService
    {
        // Colección dinámica de libros
        private List<Libro> libros = new List<Libro>();

        // Agregar un libro
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        // Eliminar un libro por su ISBN
        public bool EliminarLibro(string isbn)
        {
            Libro? libro = BuscarPorISBN(isbn);

            if (libro != null)
            {
                libros.Remove(libro);
                return true;
            }

            return false;
        }

        // Obtener todos los libros
        public List<Libro> ObtenerTodos()
        {
            return new List<Libro>(libros);
        }

        // Buscar libro por ISBN
        public Libro? BuscarPorISBN(string isbn)
        {
            return libros.FirstOrDefault(libro =>
                libro.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        // Buscar libros por título
        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libros.Where(libro =>
                libro.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Buscar libros por autor
        public List<Libro> BuscarPorAutor(string autor)
        {
            return libros.Where(libro =>
                libro.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Ordenar libros por título
        public List<Libro> OrdenarPorTitulo()
        {
            return libros.OrderBy(libro => libro.Titulo).ToList();
        }

        // KPI: cantidad total de libros
        public int ObtenerTotalLibros()
        {
            return libros.Count;
        }

        // KPI: cantidad de libros disponibles
        public int ObtenerLibrosDisponibles()
        {
            return libros.Count(libro => libro.Disponible);
        }

        // KPI: cantidad de libros prestados
        public int ObtenerLibrosPrestados()
        {
            return libros.Count(libro => !libro.Disponible);
        }
    }
}
