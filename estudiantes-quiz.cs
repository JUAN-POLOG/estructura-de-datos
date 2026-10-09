using System;

class Program
{
    static void Main()
    {
      
        int cantidad = 20;

        // Arreglos paralelos
        string[] nombres = new string[cantidad];
        double[] calificaciones = new double[cantidad];

        // Pedir los nombres y las notas
        for (int i = 0; i < cantidad; i++)
        {
            // Pedir nombre
            for (int j = 0; j < 1; j++)
            {
                Console.Write("Ingrese el nombre del estudiante " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();

                // Verificar que el nombre no este vacio
                if (nombres[i] == "")
                {
                    Console.WriteLine("El nombre no puede estar vacio.");
                    j--;
                }
            }

            // Pedir nota
            for (int j = 0; j < 1; j++)
            {
                Console.Write("Ingrese la nota de " + nombres[i] + " (0.0 - 5.0): ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());

                // Verificar que la nota este entre 0 y 5
                if (calificaciones[i] < 0 || calificaciones[i] > 5)
                {
                    Console.WriteLine("La nota debe estar entre 0.0 y 5.0.");
                    j--;
                }
            }

            Console.WriteLine();
        }

        // Variables para las estadisticas
        double suma = 0;
        double mayor = calificaciones[0];
        double menor = calificaciones[0];

        int aprobados = 0;
        int reprobados = 0;

        // Calcular las estadisticas
        for (int i = 0; i < cantidad; i++)
        {
            
            suma = suma + calificaciones[i];

            
            if (calificaciones[i] > mayor)
            {
                mayor = calificaciones[i];
            }

          
            if (calificaciones[i] < menor)
            {
                menor = calificaciones[i];
            }

           
            if (calificaciones[i] >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

       
        double promedio = suma / cantidad;

       
        Console.WriteLine("======================================");
        Console.WriteLine("           REPORTE FINAL");
        Console.WriteLine("======================================");

        
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(nombres[i] + " - " + calificaciones[i]);
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota mayor: " + mayor);
        Console.WriteLine("Nota menor: " + menor);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
