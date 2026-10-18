
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "ventas.txt";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Mouse:5");
            sw.WriteLine("Teclado:8");
            sw.WriteLine("Monitor:3");
            sw.WriteLine("Audifonos:12");
        }

        string[] lineas = File.ReadAllLines(ruta);

        int total = 0;
        int mayorCantidad = 0;
        string productoMasVendido = "";

        foreach (string linea in lineas)
        {
            string[] campos = linea.Split(':');

            string producto = campos[0];
            int cantidad = int.Parse(campos[1]);

            total += cantidad;

            if (cantidad > mayorCantidad)
            {
                mayorCantidad = cantidad;
                productoMasVendido = producto;
            }
        }

        Console.WriteLine(
            "Total de unidades vendidas: " + total);

        Console.WriteLine(
            "Producto mas vendido: " + productoMasVendido);

        Console.WriteLine(
            "Cantidad vendida: " + mayorCantidad);
    }
}
