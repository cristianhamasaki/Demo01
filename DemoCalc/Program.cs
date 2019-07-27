using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (true)
            //Console.WriteLine();
            //Console.WriteLine();

            //if (true)
            //{ 
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //1. Ingresar el primer número
            string primerNumero;
            Console.Write("Ingrese el primer número: ");
            primerNumero = Console.ReadLine();

            //2. Pedir operacion
            string operacion;
            Console.Write("Ingrese S (suma) o R (resta): ");
            operacion = Console.ReadLine();

            //3. Ingresar segundo número
            string segundoNumero;
            Console.Write("Ingrese el segundo número: ");
            segundoNumero = Console.ReadLine();

            //4. Calcular
            int primNumero = Convert.ToInt32(primerNumero);
            int segNumero = Convert.ToInt32(segundoNumero);

            int resultado;

            if (operacion == "S")
            {
                resultado = primNumero + segNumero;
            }
            else if(operacion == "R")
            {
                resultado = primNumero - segNumero;
            }
            else 
            {
                resultado = 0;
            }
            //5. Mostrar resultado
            int contador = 5;
            while (contador > 0)
            {
                Console.Write("\rEl resultado estará disponible en " + contador);
                System.Threading.Thread.Sleep(1000);
                contador--;
            }
            Console.WriteLine("\rEl resultado es " + resultado);

            //FIN
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
