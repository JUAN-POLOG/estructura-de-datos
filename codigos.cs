using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ejercicio 2. búsqueda y modificación de información en vectores
            // operaciones: búsqueda lineal, verificación de existencia
            // y actualización de un elemento de un array

            int[] codigos = new int[20];

         
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine($"Ingrese el código {i + 1}: ");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine("\nCódigos actuales:");

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine(codigos[i]);
            }

            Console.WriteLine("\nIngrese el código que desea actualizar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            if (indiceEncontrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo código:");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nCódigo actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("\nError: el código no existe.");
            }

            
            Console.WriteLine("\nCódigos actuales:");

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine(codigos[i]);
            }

            Console.WriteLine($"\nValor del índice encontrado: {indiceEncontrado}");
        }
    }
}
