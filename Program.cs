
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
            Console.WriteLine("==========================================");
            Console.WriteLine("       SISTEMA DE GESTIÓN DE BIBLIOTECA");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.WriteLine("==========================================");

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
                    ConfirmExitAndSave();
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
            Console.WriteLine("==========================================");
            Console.WriteLine("              MENÚ DE LIBROS");
            Console.WriteLine("==========================================");
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
            Console.WriteLine("==========================================");
            Console.WriteLine("             MENÚ DE USUARIOS");
            Console.WriteLine("==========================================");
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

    // MÓDULO DE PRÉSTAMOS
    static void ShowLoansMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("             MENÚ DE PRÉSTAMOS");
            Console.WriteLine("==========================================");
            Console.WriteLine("3.1 Crear préstamo");
            Console.WriteLine("3.2 Listar préstamos");
            Console.WriteLine("3.3 Ver detalle de préstamo");
            Console.WriteLine("3.4 Registrar devolución");
            Console.WriteLine("3.5 Eliminar préstamo");
            Console.WriteLine("0. Volver al menú principal");

            int opcion = ReadOption("Seleccione una opción: ", 0, 5);

            switch (opcion)
            {
                case 1:
                    CreateLoan();
                    break;

                case 2:
                    ListLoansMenu();
                    break;

                case 3:
                    ViewLoanDetail();
                    break;

                case 4:
                    RegisterReturn();
                    break;

                case 5:
                    DeleteLoan();
                    break;

                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void CreateLoan()
    {
        Console.WriteLine("Acción seleccionada: Crear un nuevo préstamo.");
        Console.WriteLine();
        Console.WriteLine("Validaciones necesarias:");
        Console.WriteLine("- Verificar que el usuario exista.");
        Console.WriteLine("- Verificar que el usuario esté activo.");
        Console.WriteLine("- Verificar que el libro exista.");
        Console.WriteLine("- Verificar que el libro esté disponible.");
        Console.WriteLine("- Registrar la fecha del préstamo.");
        Console.WriteLine("- Establecer la fecha límite de devolución.");
        Pause();
    }

    static void ListLoansMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== LISTAR PRÉSTAMOS =====");
            Console.WriteLine("1. Listar todos los préstamos");
            Console.WriteLine("2. Listar préstamos activos");
            Console.WriteLine("3. Listar préstamos cerrados");
            Console.WriteLine("0. Volver");

            int opcion = ReadOption("Seleccione una opción: ", 0, 3);

            switch (opcion)
            {
                case 1:
                    ListLoansAll();
                    break;

                case 2:
                    ListLoansActive();
                    break;

                case 3:
                    ListLoansClosed();
                    break;

                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void ListLoansAll()
    {
        Console.WriteLine("Acción seleccionada: Listar todos los préstamos.");
        Pause();
    }

    static void ListLoansActive()
    {
        Console.WriteLine("Acción seleccionada: Listar los préstamos activos.");
        Pause();
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("Acción seleccionada: Listar los préstamos cerrados.");
        Pause();
    }

    static void ViewLoanDetail()
    {
        Console.Write("Ingrese el ID del préstamo: ");
        string identificador = Console.ReadLine() ?? "";

        Console.WriteLine("Acción seleccionada: Consultar el detalle del préstamo.");
        Console.WriteLine("Identificador ingresado: " + identificador);
        Pause();
    }

    static void RegisterReturn()
    {
        Console.WriteLine("Acción seleccionada: Registrar devolución de un préstamo.");
        Console.WriteLine("Acciones sugeridas:");
        Console.WriteLine("- Marcar el préstamo como devuelto.");
        Console.WriteLine("- Registrar la fecha de devolución.");
        Console.WriteLine("- Cambiar el estado del libro a disponible.");
        Pause();
    }

    static void DeleteLoan()
    {
        Console.WriteLine("Acción seleccionada: Eliminar un préstamo.");
        Console.WriteLine("Reglas sugeridas:");
        Console.WriteLine("- Verificar que el préstamo exista.");
        Console.WriteLine("- Validar que no tenga procesos pendientes.");
        Console.WriteLine("- Conservar el historial de préstamos cuando corresponda.");
        Pause();
    }

    // MÓDULO DE BÚSQUEDAS Y REPORTES
    static void ShowSearchReportsMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("          BÚSQUEDAS Y REPORTES");
            Console.WriteLine("==========================================");
            Console.WriteLine("4.1 Buscar libro");
            Console.WriteLine("4.2 Buscar usuario");
            Console.WriteLine("4.3 Reportes");
            Console.WriteLine("0. Volver al menú principal");

            int opcion = ReadOption("Seleccione una opción: ", 0, 3);

            switch (opcion)
            {
                case 1:
                    SearchBook();
                    break;

                case 2:
                    SearchUser();
                    break;

                case 3:
                    ReportsMenu();
                    break;

                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void SearchBook()
    {
        Console.Clear();
        Console.WriteLine("===== BUSCAR LIBRO =====");
        Console.WriteLine("Buscar por:");
        Console.WriteLine("1. Título");
        Console.WriteLine("2. Autor");
        Console.WriteLine("3. ID o ISBN");
        Console.WriteLine("4. Categoría");

        int opcion = ReadOption("Seleccione el criterio de búsqueda: ", 1, 4);

        Console.Write("Ingrese el dato que desea buscar: ");
        string dato = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Búsqueda simulada de libros por título: " + dato);
                break;

            case 2:
                Console.WriteLine("Búsqueda simulada de libros por autor: " + dato);
                break;

            case 3:
                Console.WriteLine("Búsqueda simulada de libros por ID o ISBN: " + dato);
                break;

            case 4:
                Console.WriteLine("Búsqueda simulada de libros por categoría: " + dato);
                break;
        }

        Pause();
    }

    static void SearchUser()
    {
        Console.Clear();
        Console.WriteLine("===== BUSCAR USUARIO =====");
        Console.WriteLine("Buscar por:");
        Console.WriteLine("1. Nombre");
        Console.WriteLine("2. ID o documento");

        int opcion = ReadOption("Seleccione el criterio de búsqueda: ", 1, 2);

        Console.Write("Ingrese el dato que desea buscar: ");
        string dato = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Búsqueda simulada de usuarios por nombre: " + dato);
                break;

            case 2:
                Console.WriteLine("Búsqueda simulada de usuarios por ID o documento: " + dato);
                break;
        }

        Pause();
    }

    static void ReportsMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ DE REPORTES =====");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Reporte de préstamos vencidos");
            Console.WriteLine("4. Resumen general");
            Console.WriteLine("0. Volver");

            int opcion = ReadOption("Seleccione una opción: ", 0, 4);

            switch (opcion)
            {
                case 1:
                    ReportByUser();
                    break;

                case 2:
                    ReportByBook();
                    break;

                case 3:
                    ReportOverdue();
                    break;

                case 4:
                    ReportSummary();
                    break;

                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void ReportByUser()
    {
        Console.Write("Ingrese el ID o documento del usuario: ");
        string identificador = Console.ReadLine() ?? "";

        Console.WriteLine("Generando reporte simulado de préstamos por usuario.");
        Console.WriteLine("Usuario consultado: " + identificador);
        Pause();
    }

    static void ReportByBook()
    {
        Console.Write("Ingrese el ID o ISBN del libro: ");
        string identificador = Console.ReadLine() ?? "";

        Console.WriteLine("Generando reporte simulado de préstamos por libro.");
        Console.WriteLine("Libro consultado: " + identificador);
        Pause();
    }

    static void ReportOverdue()
    {
        Console.WriteLine("Generando reporte simulado de préstamos vencidos.");
        Console.WriteLine("Se deben identificar los préstamos cuya fecha límite ya pasó.");
        Pause();
    }

    static void ReportSummary()
    {
        Console.WriteLine("Generando resumen general de la biblioteca.");
        Console.WriteLine("El resumen puede incluir:");
        Console.WriteLine("- Total de libros registrados.");
        Console.WriteLine("- Total de usuarios registrados.");
        Console.WriteLine("- Total de préstamos.");
        Console.WriteLine("- Préstamos activos y cerrados.");
        Console.WriteLine("- Préstamos vencidos.");
        Pause();
    }

    // MÓDULO DE GUARDAR / CARGAR DATOS
    static void ShowPersistenceMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("===== GUARDAR / CARGAR DATOS =====");
            Console.WriteLine("5.1 Guardar datos");
            Console.WriteLine("5.2 Cargar datos");
            Console.WriteLine("5.3 Reiniciar datos");
            Console.WriteLine("0. Volver al menú principal");

            int opcion = ReadOption("Seleccione una opción: ", 0, 3);

            switch (opcion)
            {
                case 1:
                    SaveData();
                    break;

                case 2:
                    LoadData();
                    break;

                case 3:
                    ConfirmResetData();
                    break;

                case 0:
                    volver = true;
                    break;
            }
        }
    }

    static void SaveData()
    {
        Console.WriteLine("Acción seleccionada: Guardar datos.");
        Console.WriteLine("La operación de guardar datos se encuentra simulada.");
        Console.WriteLine("En una implementación futura se almacenaría la información de la biblioteca.");
        Pause();
    }

    static void LoadData()
    {
        Console.WriteLine("Acción seleccionada: Cargar datos.");
        Console.WriteLine("La operación de cargar datos se encuentra simulada.");
        Console.WriteLine("En una implementación futura se recuperaría la información almacenada.");
        Pause();
    }

    static void ConfirmResetData()
    {
        string respuesta;

        do
        {
            Console.Write("¿Está seguro de que desea reiniciar los datos? (S/N): ");
            respuesta = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (respuesta != "S" && respuesta != "N")
            {
                Console.WriteLine("Respuesta no válida. Escriba S para confirmar o N para cancelar.");
            }

        } while (respuesta != "S" && respuesta != "N");

        if (respuesta == "S")
        {
            ResetData();
        }
        else
        {
            Console.WriteLine("Operación cancelada. Los datos se mantienen.");
        }

        Pause();
    }

    static void ResetData()
    {
        Console.WriteLine("Acción seleccionada: Reiniciar datos.");
        Console.WriteLine("La operación de reinicio se encuentra simulada.");
        Console.WriteLine("No se han eliminado datos reales.");
    }

    // CONFIRMACIÓN DE SALIDA
    static void ConfirmExitAndSave()
    {
        string respuesta;

        do
        {
            Console.Write("¿Desea guardar antes de salir? (S/N): ");
            respuesta = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (respuesta != "S" && respuesta != "N")
            {
                Console.WriteLine("Respuesta no válida. Escriba S o N.");
            }

        } while (respuesta != "S" && respuesta != "N");

        if (respuesta == "S")
        {
            SaveData();
        }

        Console.WriteLine("Saliendo del sistema de gestión de biblioteca.");
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

    // PAUSA
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
