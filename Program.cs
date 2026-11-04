
using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    // MENÚ PRINCIPAL
    static void ShowMainMenu()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("===== SISTEMA DE GESTIÓN DE BIBLIOTECA =====");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");

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
                    Console.WriteLine("Módulo de préstamos pendiente de implementar.");
                    Pause();
                    break;
                case 4:
                    Console.WriteLine("Módulo de búsquedas y reportes pendiente de implementar.");
                    Pause();
                    break;
                case 5:
                    Console.WriteLine("Módulo de guardar y cargar datos pendiente de implementar.");
                    Pause();
                    break;
                case 6:
                    Console.WriteLine("Ha seleccionado la opción Salir.");
                    continuar = false;
                    break;
            }
        }
    }

    // MÓDULO DE LIBROS
    static void ShowBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ DE LIBROS =====");
            Console.WriteLine("1.1 Registrar libro");
            Console.WriteLine("1.2 Listar libros");
            Console.WriteLine("1.3 Ver detalle de libro");
            Console.WriteLine("1.4 Actualizar libro");
            Console.WriteLine("1.5 Eliminar libro");
            Console.WriteLine("0. Volver al menú principal");

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

    static void RegisterBook()
    {
        Console.WriteLine("Acción seleccionada: Registrar un nuevo libro.");
        Pause();
    }

    static void ListBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== LISTAR LIBROS =====");
            Console.WriteLine("1. Listar todos los libros");
            Console.WriteLine("2. Listar libros disponibles");
            Console.WriteLine("3. Listar libros prestados");
            Console.WriteLine("0. Volver");

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
        Console.WriteLine("Acción seleccionada: Listar todos los libros.");
        Pause();
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("Acción seleccionada: Listar libros disponibles.");
        Pause();
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("Acción seleccionada: Listar libros prestados.");
        Pause();
    }

    static void ViewBookDetail()
    {
        Console.Write("Ingrese el ID o ISBN del libro: ");
        string identificador = Console.ReadLine() ?? "";

        Console.WriteLine("Acción seleccionada: Consultar el detalle del libro.");
        Console.WriteLine("Identificador ingresado: " + identificador);
        Pause();
    }

    static void UpdateBookMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== ACTUALIZAR LIBRO =====");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("0. Volver");

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
        Console.WriteLine("Acción seleccionada: Editar título del libro.");
        Pause();
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("Acción seleccionada: Editar autor del libro.");
        Pause();
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("Acción seleccionada: Editar año y categoría del libro.");
        Pause();
    }

    static void DeleteBook()
    {
        Console.WriteLine("Acción seleccionada: Eliminar libro.");
        Console.WriteLine("Validar no permitir si está prestado.");
        Pause();
    }

    // MÓDULO DE USUARIOS
    static void ShowUsersMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ DE USUARIOS =====");
            Console.WriteLine("2.1 Registrar usuario");
            Console.WriteLine("2.2 Listar usuarios");
            Console.WriteLine("2.3 Ver detalle de usuario");
            Console.WriteLine("2.4 Actualizar usuario");
            Console.WriteLine("2.5 Eliminar usuario");
            Console.WriteLine("0. Volver al menú principal");

            int opcion = ReadOption("Seleccione una opción: ", 0, 5);

            switch (opcion)
            {
                case 1:
                    RegisterUser();
                    break;
                case 2:
                    ListUsers();
                    break;
                case 3:
                    ViewUserDetail();
                    break;
                case 4:
                    UpdateUserMenu();
                    break;
                case 5:
                    DeleteUser();
                    break;
                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void RegisterUser()
    {
        Console.WriteLine("Acción seleccionada: Registrar un nuevo usuario.");
        Pause();
    }

    static void ListUsers()
    {
        Console.WriteLine("Acción seleccionada: Listar todos los usuarios registrados.");
        Pause();
    }

    static void ViewUserDetail()
    {
        Console.Write("Ingrese el ID o documento del usuario: ");
        string identificador = Console.ReadLine() ?? "";

        Console.WriteLine("Acción seleccionada: Consultar el detalle del usuario.");
        Console.WriteLine("Identificador ingresado: " + identificador);
        Pause();
    }

    static void UpdateUserMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== ACTUALIZAR USUARIO =====");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar usuario");
            Console.WriteLine("0. Volver");

            int opcion = ReadOption("Seleccione una opción: ", 0, 3);

            switch (opcion)
            {
                case 1:
                    EditUserName();
                    break;
                case 2:
                    EditUserContact();
                    break;
                case 3:
                    ToggleUserActiveStatus();
                    break;
                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void EditUserName()
    {
        Console.WriteLine("Acción seleccionada: Editar el nombre del usuario.");
        Pause();
    }

    static void EditUserContact()
    {
        Console.WriteLine("Acción seleccionada: Editar los datos de contacto del usuario.");
        Pause();
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine("Acción seleccionada: Activar o desactivar el usuario.");
        Pause();
    }

    static void DeleteUser()
    {
        Console.WriteLine("Acción seleccionada: Eliminar usuario.");
        Console.WriteLine("Validar no permitir si tiene préstamos activos.");
        Pause();
    }

    // VALIDACIÓN DE ENTRADAS
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

            Console.WriteLine("Entrada no válida. Intente nuevamente.");
        }
    }

    // PAUSA PARA LEER LOS MENSAJES
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
