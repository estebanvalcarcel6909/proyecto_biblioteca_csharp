
namespace system_books.Models
{
    public class Prestamo
    {
        // Propiedades
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; }

        // Constructor vacío
        public Prestamo()
        {
            Id = 0;
            Libro = new Libro();
            Usuario = new Usuario();
            FechaPrestamo = DateTime.Now;
            FechaVencimiento = DateTime.Now.AddDays(15);
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        // Constructor completo
        public Prestamo(
            int id,
            Libro libro,
            Usuario usuario,
            DateTime fechaPrestamo,
            DateTime fechaVencimiento)
        {
            Id = id;
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = fechaPrestamo;
            FechaVencimiento = fechaVencimiento;
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        // Verificar si el préstamo está vencido
        public bool EstaVencido()
        {
            return FechaDevolucion == null &&
                   DateTime.Now.Date > FechaVencimiento.Date;
        }

        // Calcular días transcurridos
        public int DiasTranscurridos()
        {
            return (DateTime.Now.Date - FechaPrestamo.Date).Days;
        }

        // Resumen corto
        public string ResumenCorto()
        {
            return $"Préstamo #{Id} - {Libro.Titulo} - {Usuario.Nombre} {Usuario.Apellido}";
        }

        // Detalle completo
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                   $"Libro: {Libro.Titulo}\n" +
                   $"Usuario: {Usuario.Nombre} {Usuario.Apellido}\n" +
                   $"Fecha de préstamo: {FechaPrestamo:dd/MM/yyyy}\n" +
                   $"Fecha de vencimiento: {FechaVencimiento:dd/MM/yyyy}\n" +
                   $"Fecha de devolución: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}\n" +
                   $"Estado: {Estado}\n" +
                   $"¿Está vencido?: {(EstaVencido() ? "Sí" : "No")}\n" +
                   $"Días transcurridos: {DiasTranscurridos()}";
        }

        // Sobrescritura de ToString()
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
