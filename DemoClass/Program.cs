using System;

namespace DemoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Promedio promediador = new Promedio();

            Alumno[] alumnos = new Alumno[4];
            alumnos[0] = new Alumno();
            alumnos[0].Notas = new double[3];
            alumnos[0].Nombre = "Charly";
            alumnos[0].Notas[0] = 8.5;
            alumnos[0].Notas[1] = 7;
            alumnos[0].Notas[2] = 9;

            alumnos[1] = new Alumno
            {
                Nombre = "Chino",
                Notas = new double[] { 7, 6, 7.5 }
            };

            alumnos[2] = new Alumno
            {
                Nombre = "Matias",
                Notas = new double[] { 7, 8.5, 7.5 }
            };

            alumnos[3] = new Alumno
            {
                Nombre = "Daniel",
                Notas = new double[] { 8, 7.5, 9.5 }
            };

            foreach(Alumno alumn in alumnos)
            {
                double prome = promediador.CalcularPromedio(alumn.Notas);
                Console.WriteLine($"Nombre: {alumn.Nombre} - Promedio: {prome}");
            }



            Console.ReadKey();
        }
    }














    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Crea una instancia de la clase Promedio
    //        Promedio promediador = new Promedio();

    //        //Ejecuta el calculador de promedio 2 veces con distintas notas
    //        double unPromedio = promediador.CalcularPromedio();
    //        double otroPromedio = promediador.CalcularPromedio(3, 9, 9);

    //        //Muestra ambos promedios
    //        Console.WriteLine($"Un Promedio: {unPromedio}");
    //        Console.WriteLine($"Otro Promedio: {otroPromedio}");

    //        Console.ReadKey();
    //    }
    //}
    //class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        Triangulo miTriang = new Triangulo();
    //        miTriang.Altura = 10;
    //        miTriang.Base = 20;

    //        double superficie = miTriang.CalcSup();

    //        Console.WriteLine("Superficie: " + superficie);
    //        Console.ReadKey();
    //    }
    //}

}
