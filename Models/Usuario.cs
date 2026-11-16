
namespace system_books.Models
{
    public class Usuario
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        // Constructor vacío
        public Usuario()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Activo = true;
        }

        // Constructor completo
        public Usuario(int id, string nombre, string apellido,
                       string correo, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Activo = true;
        }

        // Método: resumen corto
        public string ResumenCorto()
        {
            return $"{Nombre} {Apellido} - {Correo}";
        }

        // Método: detalle completo
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                   $"Nombre: {Nombre}\n" +
                   $"Apellido: {Apellido}\n" +
                   $"Correo: {Correo}\n" +
                   $"Teléfono: {Telefono}\n" +
                   $"Activo: {(Activo ? "Sí" : "No")}";
        }

        // Sobrescritura de ToString()
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
