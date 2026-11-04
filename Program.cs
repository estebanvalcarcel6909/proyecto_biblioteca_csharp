
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Sistema de Gestión de Biblioteca";

        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("       SISTEMA DE GESTIÓN DE BIBLIOTECA");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            string entrada = Console.ReadLine() ?? "";

            if (!int.TryParse(entrada, out int opcion))
            {
                Console.WriteLine();
                Console.WriteLine("Error: debe ingresar un número válido.");
                Pause();
                continue;
            }

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
                    Console.WriteLine();
                    Console.WriteLine("Ha seleccionado la opción Salir.");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Opción no válida. Seleccione una opción del 1 al 6.");
                    Pause();
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Gracias por utilizar el sistema de biblioteca.");
    }

    static void ShowBooksMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Módulo de libros seleccionado.");
        Console.WriteLine("El submenú de libros se desarrollará posteriormente.");
        Pause();
    }

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

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
