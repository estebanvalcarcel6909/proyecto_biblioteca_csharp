
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Sistema de Gestión de Biblioteca";
        ShowMainMenu();
    }

    // MENÚ PRINCIPAL
    static void ShowMainMenu()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("       SISTEMA DE GESTIÓN DE BIBLIOTECA");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.WriteLine();

            int opcion = ReadOption("Seleccione una opción: ", 1, 6);

            switch (opcion)
            {
                case 1:
                    ShowBooksMenu();
                    break;
                case 2:
                    ShowUsersMenu();
                    break;
                case 3:
                    ShowLoansMenu();
                    break;
                case 4:
                    ShowSearchReportsMenu();
                    break;
                case 5:
                    ShowPersistenceMenu();
                    break;
                case 6:
                    continuar = false;
                    Console.WriteLine("Ha seleccionado la opción Salir.");
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Gracias por utilizar el sistema de biblioteca.");
    }

    // MENÚ DE LIBROS
    static void ShowBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("              MENÚ DE LIBROS");
            Console.WriteLine("==========================================");
            Console.WriteLine("1.1 Registrar libro");
            Console.WriteLine("1.2 Listar libros");
            Console.WriteLine("1.3 Ver detalle de libro");
            Console.WriteLine("1.4 Actualizar libro");
            Console.WriteLine("1.5 Eliminar libro");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine();

            int opcion = ReadOption("Seleccione una opción: ", 0, 5);

            switch (opcion)
            {
                case 1:
                    RegisterBook();
                    break;
                case 2:
                    ListBooksMenu();
                    break;
                case 3:
                    ViewBookDetail();
                    break;
                case 4:
                    UpdateBookMenu();
                    break;
                case 5:
                    DeleteBook();
                    break;
                case 0:
                    volver = true;
                    break;
            }
        }
    }

    // REGISTRAR LIBRO
    static void RegisterBook()
    {
        Console.Clear();
        Console.WriteLine("REGISTRAR LIBRO");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Acción seleccionada: Registrar un nuevo libro.");
        Console.WriteLine("Se solicitarían los datos del libro para su registro.");
        Pause();
    }

    // SUBMENÚ LISTAR LIBROS
    static void ListBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("             LISTAR LIBROS");
            Console.WriteLine("==========================================");
            Console.WriteLine("1.2.1 Listar todos los libros");
            Console.WriteLine("1.2.2 Listar libros disponibles");
            Console.WriteLine("1.2.3 Listar libros prestados");
            Console.WriteLine("0. Volver al menú de libros");
            Console.WriteLine();

            int opcion = ReadOption("Seleccione una opción: ", 0, 3);

            switch (opcion)
            {
                case 1:
                    ListBooksAll();
                    break;
                case 2:
                    ListBooksAvailable();
                    break;
                case 3:
                    ListBooksBorrowed();
                    break;
                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void ListBooksAll()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Listar todos los libros.");
        Console.WriteLine("Se mostraría el listado completo de libros registrados.");
        Pause();
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Listar libros disponibles.");
        Console.WriteLine("Se mostrarían únicamente los libros disponibles.");
        Pause();
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Listar libros prestados.");
        Console.WriteLine("Se mostrarían únicamente los libros que están prestados.");
        Pause();
    }

    // VER DETALLE DE LIBRO
    static void ViewBookDetail()
    {
        Console.Clear();
        Console.WriteLine("VER DETALLE DE LIBRO");
        Console.WriteLine("------------------------------------------");
        Console.Write("Ingrese el ID o ISBN del libro: ");

        string identificador = Console.ReadLine() ?? "";

        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Consultar el detalle del libro.");
        Console.WriteLine("Identificador ingresado: " + identificador);
        Console.WriteLine("Se mostrarían los detalles del libro solicitado.");
        Pause();
    }

    // SUBMENÚ ACTUALIZAR LIBRO
    static void UpdateBookMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("            ACTUALIZAR LIBRO");
            Console.WriteLine("==========================================");
            Console.WriteLine("1.4.1 Editar título");
            Console.WriteLine("1.4.2 Editar autor");
            Console.WriteLine("1.4.3 Editar año / categoría");
            Console.WriteLine("0. Volver al menú de libros");
            Console.WriteLine();

            int opcion = ReadOption("Seleccione una opción: ", 0, 3);

            switch (opcion)
            {
                case 1:
                    EditBookTitle();
                    break;
                case 2:
                    EditBookAuthor();
                    break;
                case 3:
                    EditBookYearCategory();
                    break;
                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void EditBookTitle()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Editar el título del libro.");
        Console.WriteLine("Se solicitaría el nuevo título para actualizarlo.");
        Pause();
    }

    static void EditBookAuthor()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Editar el autor del libro.");
        Console.WriteLine("Se solicitaría el nuevo autor para actualizarlo.");
        Pause();
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Editar año y categoría.");
        Console.WriteLine("Se solicitarían los nuevos datos para actualizarlos.");
        Pause();
    }

    // ELIMINAR LIBRO
    static void DeleteBook()
    {
        Console.WriteLine();
        Console.WriteLine("Acción seleccionada: Eliminar libro.");
        Console.WriteLine("Validar no permitir si está prestado.");
        Pause();
    }

    // MÓDULOS PENDIENTES
    static void ShowUsersMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Módulo de usuarios seleccionado.");
        Console.WriteLine("El submenú de usuarios se desarrollará posteriormente.");
        Pause();
    }

    static void ShowLoansMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Módulo de préstamos seleccionado.");
        Console.WriteLine("El submenú de préstamos se desarrollará posteriormente.");
        Pause();
    }

    static void ShowSearchReportsMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Módulo de búsquedas y reportes seleccionado.");
        Console.WriteLine("Este módulo se desarrollará posteriormente.");
        Pause();
    }

    static void ShowPersistenceMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Módulo de guardar y cargar datos seleccionado.");
        Console.WriteLine("Este módulo se desarrollará posteriormente.");
        Pause();
    }

    // VALIDAR ENTRADAS NUMÉRICAS
    static int ReadOption(string mensaje, int minimo, int maximo)
    {
        int opcion;

        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out opcion) &&
                opcion >= minimo && opcion <= maximo)
            {
                return opcion;
            }

            Console.WriteLine("Opción no válida. Intente nuevamente.");
            Console.WriteLine();
        }
    }

    // PAUSA
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
