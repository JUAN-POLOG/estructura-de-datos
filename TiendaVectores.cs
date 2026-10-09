using System;
using System.Security.Cryptography;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Una tienda registra las ventas de 10 días
        //v
        double[] ventas = {
            2000.000,
            302.300,
            400.000,
            300.233,
            700.410,
            740.432,
            100.233,
            823.231,
            902.211,
            500.000
        };

        double total = 0;
        double menorventa = ventas[0];
        double mayorventa = ventas[0];

        int diamayorventa = 0;
        int diamenorventa = 0;

        for (int i = 0; i < ventas.Length; i++)
        {
            total += ventas[i];

            if (ventas[i] > mayorventa)
            {
                mayorventa = ventas[i];
                diamayorventa = i;
            }

            if (ventas[i] < menorventa)
            {
                menorventa = ventas[i];
                diamenorventa = i;
            }
        }

        double promedio = total / ventas.Length;
        int diassobrepromedio = 0;

        for (int i = 0; i < ventas.Length; i++)
            if (ventas[i] > promedio)
            {
                diassobrepromedio++;
            }

        Console.WriteLine("=====================reporte de ventas============================");
        Console.WriteLine();

        Console.WriteLine($"Total de ventas: ${total}");
        Console.WriteLine($"promedio diario:  ${promedio}");
        Console.WriteLine();

        Console.WriteLine($"Mayor venta: ${mayorventa + 1}- el dia {mayorventa + 1}");
        Console.WriteLine($"Menor venta:  ${menorventa + 1} - el dia {menorventa + 1}");

        Console.WriteLine($"Dias que superaron el promedio de ventas {diassobrepromedio}");
        Console.WriteLine();

        Console.WriteLine("ventas por dias");
        for (int i = 0; i < ventas.Length; i++)
        {
            Console.WriteLine($"dia {i + 1}: ${ventas[i]:f3}");


        }
    }
}
