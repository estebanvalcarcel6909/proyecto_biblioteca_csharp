using System;
using System.Collections.Generic;

namespace system_books.Examples
{
    public class ArrayVsListDemo
    {
        public static void MostrarDemostracion()
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine(" DEMOSTRACIÓN: ARRAY VS LIST");
            Console.WriteLine("====================================");

            // --------------------------------
            // 1. DEMOSTRACIÓN DE UN ARRAY
            // --------------------------------

            Console.WriteLine("\n1. TRABAJANDO CON ARRAYS");

            // Un array tiene un tamaño fijo.
            string[] librosArray = new string[3];

            librosArray[0] = "Cien años de soledad";
            librosArray[1] = "El principito";
            librosArray[2] = "Don Quijote de la Mancha";

            Console.WriteLine("Libros almacenados en el array:");

            foreach (string libro in librosArray)
            {
                Console.WriteLine($"- {libro}");
            }

            Console.WriteLine($"Cantidad de elementos: {librosArray.Length}");

            // --------------------------------
            // 2. DEMOSTRACIÓN DE UNA LIST
            // --------------------------------

            Console.WriteLine("\n2. TRABAJANDO CON LIST");

            // Una List permite agregar y eliminar elementos dinámicamente.
            List<string> librosLista = new List<string>();

            librosLista.Add("Cien años de soledad");
            librosLista.Add("El principito");
            librosLista.Add("Don Quijote de la Mancha");

            Console.WriteLine("Libros almacenados en la lista:");

            foreach (string libro in librosLista)
            {
                Console.WriteLine($"- {libro}");
            }

            Console.WriteLine($"Cantidad inicial de elementos: {librosLista.Count}");

            // Agregar un nuevo libro.
            librosLista.Add("La vorágine");

            Console.WriteLine("\nDespués de agregar un libro:");
            Console.WriteLine($"Cantidad de elementos: {librosLista.Count}");

            // Eliminar un libro.
            librosLista.Remove("El principito");

            Console.WriteLine("\nDespués de eliminar un libro:");
            Console.WriteLine($"Cantidad de elementos: {librosLista.Count}");

            Console.WriteLine("\nLibros actuales en la lista:");

            foreach (string libro in librosLista)
            {
                Console.WriteLine($"- {libro}");
            }

            // --------------------------------
            // 3. CONCLUSIÓN
            // --------------------------------

            Console.WriteLine("\n3. CONCLUSIÓN");

            Console.WriteLine(
                "Array: tiene un tamaño fijo y no permite cambiarlo directamente.");

            Console.WriteLine(
                "List: permite agregar, eliminar y administrar elementos dinámicamente.");

            Console.WriteLine(
                "En el sistema de biblioteca utilizamos List porque la cantidad de libros, usuarios y préstamos puede cambiar.");

            Console.WriteLine("\n====================================");
            Console.WriteLine(" FIN DE LA DEMOSTRACIÓN");
            Console.WriteLine("====================================");
        }
    }
}