
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

        // KPI: cantidad total de préstamos
        public int ObtenerTotalPrestamos()
        {
            return prestamos.Count;
        }

        // KPI: cantidad de préstamos activos
        public int ObtenerPrestamosActivos()
        {
            return prestamos.Count(prestamo =>
                prestamo.Estado == EstadoPrestamo.Activo);
        }

        // KPI: cantidad de préstamos vencidos
        public int ObtenerPrestamosVencidos()
        {
            return prestamos.Count(prestamo =>
                prestamo.Estado == EstadoPrestamo.Vencido ||
                prestamo.EstaVencido());
        }

        // KPI: cantidad de préstamos devueltos
        public int ObtenerPrestamosDevueltos()
        {
            return prestamos.Count(prestamo =>
                prestamo.Estado == EstadoPrestamo.Devuelto);
        }

        // KPI: promedio de días de préstamo
        public double ObtenerPromedioDiasPrestamo()
        {
            if (prestamos.Count == 0)
            {
                return 0;
            }

            double totalDias = prestamos.Average(prestamo =>
            {
                DateTime fechaFinal =
                    prestamo.FechaDevolucion ?? DateTime.Now;

                return (fechaFinal.Date -
                        prestamo.FechaPrestamo.Date).TotalDays;
            });

            return Math.Round(totalDias, 2);
        }
    }
}
