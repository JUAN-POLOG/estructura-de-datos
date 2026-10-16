using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productos
{
    class Program
    {
        static void Main()
        {
            string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos juan polo\\Productos.csv";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Nombre,Precio");
                sw.WriteLine("1,portatil,4500");
                sw.WriteLine("2,MouseInalambrico,15");
                sw.WriteLine("3,monitor,500");
            }

            string[] lineas = File.ReadAllLines(ruta);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                double precio = double.Parse(campos[2]);

                if (precio > 100)
                {
                    Console.WriteLine($"{campos[1]} - ${precio}");
                }
            }
        }
    }

}
