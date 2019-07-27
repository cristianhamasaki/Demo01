using System;

namespace DemoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. se creo clase promedio
            //2. se creo metodo para calcular promedio
            //3. al metodo se le hace llegar por parametro un array de notas. 
            //   Esto se hizo para que no haya limite de la cantidad de notas que pueden llegar
            //   por alumnos.
            //4. se creo clase alumno
            //5. se le asignaron atributos PUBLICOS para el nombre y un array de ints Notas
            //6. se instancio objeto Promedio -> esto es para utilizar el método de calculo de promedio del alumno 
            //7. Se inicio un array de Alumnos de 4 posiciones
            //8. Se crean instancias para cada alumno y se le dan Nombre y las Notas
            //   Prestar atención a como se asigno valores a los arrays y como se iniciaron
            //   Es importante porque si estan en NULL arrojará error la aplicación.

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
