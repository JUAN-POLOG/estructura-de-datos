using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ejerciocio 2. busqueda y modificacion de informacion en vectores
            // operaciones busqueda lineal,verificacion de existencia y actualizacion de un elemento de un array 

            int[] codigos = { 333,211, 212, 312, 621, 15, 12, 121, 445,669 };
            Console.WriteLine($"codigos actuales {string.Join(",", codigos)}");
            Console.WriteLine("ingrese el codigo que sea actualizar: ");
            int buaqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == buaqueda)
                {
                    indiceEncontrado = i;
                    break;
                }
            }
                    if (indiceEncontrado != -1)
                    {
                        Console.WriteLine("ingrese el nuevo codigo");
                        codigos [indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n vector actualizado: {string.Join(", ", codigos)}");

                    }
                    else
                    {
                        Console.WriteLine("\n error : el codigo no existe en en la BDD");
                    }

                

                
            
        }
    }
}
