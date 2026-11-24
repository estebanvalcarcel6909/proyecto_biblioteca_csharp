
using system_books.Models;

namespace system_books.Services
{
    public class PrestamoService
    {
        // Colección dinámica de préstamos
        private List<Prestamo> prestamos = new List<Prestamo>();

        // Agregar un préstamo
        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

        // Eliminar un préstamo por su ID
        public bool EliminarPrestamo(int id)
        {
            Prestamo? prestamo = BuscarPorId(id);

            if (prestamo != null)
            {
                prestamos.Remove(prestamo);
                return true;
            }

            return false;
        }

        // Obtener todos los préstamos
        public List<Prestamo> ObtenerTodos()
        {
            return new List<Prestamo>(prestamos);
        }

        // Buscar préstamo por ID
        public Prestamo? BuscarPorId(int id)
        {
            return prestamos.FirstOrDefault(prestamo =>
                prestamo.Id == id);
        }

        // Buscar préstamos por estado
        public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
        {
            return prestamos.Where(prestamo =>
                prestamo.Estado == estado)
                .ToList();
        }

        // Buscar préstamos vencidos
        public List<Prestamo> BuscarVencidos()
        {
            return prestamos.Where(prestamo =>
                prestamo.EstaVencido())
                .ToList();
        }

        // Ordenar préstamos por fecha de vencimiento
        public List<Prestamo> OrdenarPorFechaVencimiento()
        {
            return prestamos
                .OrderBy(prestamo => prestamo.FechaVencimiento)
                .ToList();
        }
    }
}
