using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace ConsoleApp3
{
    public class programs
    {
        //procedimiento sumar 
        public static void  ImprimirSuma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine (suma);

        }

        public static void  MostrarPotenciaX(double num1, double potencia)
        {
            double resultado = Math.Pow( num1, potencia);
            Console.WriteLine ($"la pontencia del numero {num1} elevado a la potencia {potencia} es: { resultado}");
        }

        static void ModificarValor (int n)
        {
            n = n + 1;
            Console.WriteLine ($"dentro del metodo; {n}" );
        }
        public static void Main(string[] args)
        {
            int x = 12, y = 3;

            ImprimirSuma(y,x);
            ImprimirSuma(1000, -1);
            MostrarPotenciaX(x, y);
            int edad = 17;
            Console.WriteLine ($"antes del metodo: {edad}");
            ModificarValor(edad);
            Console.WriteLine ($"despues del metodo: {edad}");
        }
    }
}
