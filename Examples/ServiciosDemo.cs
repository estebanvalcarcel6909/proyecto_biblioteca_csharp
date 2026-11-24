
using System;
using system_books.Models;
using system_books.Services;

namespace system_books.Examples
{
    public class ServiciosDemo
    {
        public static void MostrarDemostracion()
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine(" PRUEBAS DE LOS SERVICIOS");
            Console.WriteLine("====================================");

            // ====================================
            // 1. SERVICIO DE LIBROS
            // ====================================

            Console.WriteLine("\n========== SERVICIO DE LIBROS ==========");

            LibroService libroService = new LibroService();

            Libro libro1 = new Libro(
                1, "Cien años de soledad", "Gabriel García Márquez",
                "ISBN001", 1967);

            Libro libro2 = new Libro(
                2, "El principito", "Antoine de Saint-Exupéry",
                "ISBN002", 1943);

            Libro libro3 = new Libro(
                3, "Don Quijote de la Mancha", "Miguel de Cervantes",
                "ISBN003", 1605);

            libro3.Disponible = false;

            libroService.AgregarLibro(libro1);
            libroService.AgregarLibro(libro2);
            libroService.AgregarLibro(libro3);

            Console.WriteLine("\nTodos los libros:");

            foreach (Libro libro in libroService.ObtenerTodos())
            {
                Console.WriteLine(libro.ResumenCorto());
            }

            Console.WriteLine("\nBuscar libro por ISBN001:");

            Libro? libroEncontrado = libroService.BuscarPorISBN("ISBN001");

            Console.WriteLine(libroEncontrado?.ResumenCorto()
                ?? "Libro no encontrado.");

            Console.WriteLine("\nBuscar libros por título 'principito':");

            foreach (Libro libro in libroService.BuscarPorTitulo("principito"))
            {
                Console.WriteLine(libro.ResumenCorto());
            }

            Console.WriteLine("\nLibros ordenados por título:");

            foreach (Libro libro in libroService.OrdenarPorTitulo())
            {
                Console.WriteLine(libro.Titulo);
            }

            Console.WriteLine("\nIndicadores de libros:");
            Console.WriteLine($"Total: {libroService.ObtenerTotalLibros()}");
            Console.WriteLine($"Disponibles: {libroService.ObtenerLibrosDisponibles()}");
            Console.WriteLine($"Prestados: {libroService.ObtenerLibrosPrestados()}");

            // ====================================
            // 2. SERVICIO DE USUARIOS
            // ====================================

            Console.WriteLine("\n========== SERVICIO DE USUARIOS ==========");

            UsuarioService usuarioService = new UsuarioService();

            Usuario usuario1 = new Usuario(
                1, "Carlos", "Pérez",
                "carlos@gmail.com", "3001111111");

            Usuario usuario2 = new Usuario(
                2, "Ana", "Gómez",
                "ana@gmail.com", "3002222222");

            Usuario usuario3 = new Usuario(
                3, "Luis", "Rodríguez",
                "luis@gmail.com", "3003333333");

            usuario3.Activo = false;

            usuarioService.AgregarUsuario(usuario1);
            usuarioService.AgregarUsuario(usuario2);
            usuarioService.AgregarUsuario(usuario3);

            Console.WriteLine("\nTodos los usuarios:");

            foreach (Usuario usuario in usuarioService.ObtenerTodos())
            {
                Console.WriteLine(usuario.ResumenCorto());
            }

            Console.WriteLine("\nBuscar usuario por ID 1:");

            Usuario? usuarioEncontrado = usuarioService.BuscarPorId(1);

            Console.WriteLine(usuarioEncontrado?.ResumenCorto()
                ?? "Usuario no encontrado.");

            Console.WriteLine("\nBuscar usuarios por nombre 'Ana':");

            foreach (Usuario usuario in usuarioService.BuscarPorNombre("Ana"))
            {
                Console.WriteLine(usuario.ResumenCorto());
            }

            Console.WriteLine("\nUsuarios ordenados por nombre:");

            foreach (Usuario usuario in usuarioService.OrdenarPorNombre())
            {
                Console.WriteLine(usuario.ResumenCorto());
            }

            Console.WriteLine("\nIndicadores de usuarios:");
            Console.WriteLine($"Total: {usuarioService.ObtenerTotalUsuarios()}");
            Console.WriteLine($"Activos: {usuarioService.ObtenerUsuariosActivos()}");
            Console.WriteLine($"Inactivos: {usuarioService.ObtenerUsuariosInactivos()}");

            // ====================================
            // 3. SERVICIO DE PRÉSTAMOS
            // ====================================

            Console.WriteLine("\n========== SERVICIO DE PRÉSTAMOS ==========");

            PrestamoService prestamoService = new PrestamoService();

            Prestamo prestamo1 = new Prestamo(
                1, libro1, usuario1,
                DateTime.Now.AddDays(-3),
                DateTime.Now.AddDays(7));

            prestamo1.Estado = EstadoPrestamo.Activo;

            Prestamo prestamo2 = new Prestamo(
                2, libro2, usuario2,
                DateTime.Now.AddDays(-15),
                DateTime.Now.AddDays(-5));

            prestamo2.Estado = EstadoPrestamo.Vencido;

            Prestamo prestamo3 = new Prestamo(
                3, libro3, usuario3,
                DateTime.Now.AddDays(-10),
                DateTime.Now.AddDays(-3));

            prestamo3.Estado = EstadoPrestamo.Devuelto;
            prestamo3.FechaDevolucion = DateTime.Now.AddDays(-2);

            prestamoService.AgregarPrestamo(prestamo1);
            prestamoService.AgregarPrestamo(prestamo2);
            prestamoService.AgregarPrestamo(prestamo3);

            Console.WriteLine("\nTodos los préstamos:");

            foreach (Prestamo prestamo in prestamoService.ObtenerTodos())
            {
                Console.WriteLine(prestamo.ResumenCorto());
            }

            Console.WriteLine("\nBuscar préstamo por ID 1:");

            Prestamo? prestamoEncontrado = prestamoService.BuscarPorId(1);

            Console.WriteLine(prestamoEncontrado?.ResumenCorto()
                ?? "Préstamo no encontrado.");

            Console.WriteLine("\nBuscar préstamos vencidos:");

            foreach (Prestamo prestamo in prestamoService.BuscarVencidos())
            {
                Console.WriteLine(prestamo.ResumenCorto());
            }

            Console.WriteLine("\nPréstamos ordenados por fecha de vencimiento:");

            foreach (Prestamo prestamo in prestamoService.OrdenarPorFechaVencimiento())
            {
                Console.WriteLine(prestamo.ResumenCorto());
            }

            Console.WriteLine("\nIndicadores de préstamos:");
            Console.WriteLine($"Total: {prestamoService.ObtenerTotalPrestamos()}");
            Console.WriteLine($"Activos: {prestamoService.ObtenerPrestamosActivos()}");
            Console.WriteLine($"Vencidos: {prestamoService.ObtenerPrestamosVencidos()}");
            Console.WriteLine($"Devueltos: {prestamoService.ObtenerPrestamosDevueltos()}");
            Console.WriteLine($"Promedio de días: {prestamoService.ObtenerPromedioDiasPrestamo()}");

            Console.WriteLine("\n====================================");
            Console.WriteLine(" FIN DE LAS PRUEBAS DE SERVICIOS");
            Console.WriteLine("====================================");
        }
    }
}
