using System;

namespace pp
{
    internal class Program
    {
        static void ImprimirCabezera(
            string nombreMateria,
            int grupo,
            string nombreEstudiante,
            int edad,
            string carrera,
            int semestre,
            string ciudad,
            string universidad)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("         UNIVERSIDAD DEL CARIBE            ");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Asignatura: {nombreMateria}");
            Console.WriteLine($"Grupo: {grupo}");
            Console.WriteLine($"Nombre del estudiante: {nombreEstudiante}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Carrera: {carrera}");
            Console.WriteLine($"Semestre: {semestre}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Universidad: {universidad}");
            Console.WriteLine("===========================================");
        }

        public static void Main(string[] args)
        {
            // Llamar al procedimiento ImprimirCabezera
            ImprimirCabezera(
                "Fundamentos de Programacion",
                1,
                "Juan David Polo",
                17,
                "Ingenieria informatica",
                2,
                "Cienaga, Magdalena",
                "Universidad del Caribe"
            );

            Console.ReadKey();
        }
    }
}
