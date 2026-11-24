
namespace system_books.Models
{
    public class Libro
    {
        // Propiedades
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnioPublicacion { get; set; }
        public bool Disponible { get; set; }

        // Constructor vacío
        public Libro()
        {
            Id = 0;
            Titulo = string.Empty;
            Autor = string.Empty;
            ISBN = string.Empty;
            AnioPublicacion = 0;
            Disponible = true;
        }

        // Constructor completo
        public Libro(int id, string titulo, string autor,
                     string isbn, int anioPublicacion)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnioPublicacion = anioPublicacion;
            Disponible = true;
        }

        // Método: resumen corto
        public string ResumenCorto()
        {
            return $"{Titulo} - {Autor}";
        }

        // Método: detalle completo
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                   $"Título: {Titulo}\n" +
                   $"Autor: {Autor}\n" +
                   $"ISBN: {ISBN}\n" +
                   $"Año de publicación: {AnioPublicacion}\n" +
                   $"Disponible: {(Disponible ? "Sí" : "No")}";
        }

        // Sobrescritura de ToString()
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
