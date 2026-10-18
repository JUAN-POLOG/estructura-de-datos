
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "estudiantes.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("Juan,20,85");
            sw.WriteLine("DAVID,22,90");
            sw.WriteLine("MARIA,21,78");
        }

        string[] lineas = File.ReadAllLines(ruta);

        Console.WriteLine("Campos: Nombre, Edad, Nota");
        Console.WriteLine("Delimitador: coma (,)");
        Console.WriteLine("Tipos de datos:");

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            string nombre = campos[0];
            int edad = int.Parse(campos[1]);
            double nota = double.Parse(campos[2]);

            Console.WriteLine(
                nombre + " | Edad: " + edad +
                " | Nota: " + nota);
        }
    }
}
