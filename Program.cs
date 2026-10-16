using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class program
    {

        static void Main()
        {
            string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos juan polo\\NotasEstudiantes.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("nombre,edad,nota");
                sw.WriteLine("Juan, 22, 4.5");
                sw.WriteLine("David, 20, 3.0");
                sw.WriteLine("Alvaro, 19, 5.0");

            }
            Console.WriteLine("archivo creado exitosamente");
        }
    }
}