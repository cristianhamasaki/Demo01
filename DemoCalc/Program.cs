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
            /*
             1. Ingresar el primer número
             2. Pedir operacion
             3. Ingresar segundo número
             4. Calcular
             5. Mostrar resultado
             */
            //1.
            string primerNumero;
            Console.WriteLine("Ingrese el primer número");
            primerNumero = Console.ReadLine();

            //2.
            string operacion;
            Console.WriteLine("Ingrese S (suma) o R (resta)");
            operacion = Console.ReadLine();

            //3.
            string segundoNumero;
            Console.WriteLine("Ingrese el srgundo número");
            segundoNumero = Console.ReadLine();

            //4.
            int primNumero = Convert.ToInt32(primerNumero);
            int segNumero = Convert.ToInt32(segundoNumero);
            int resultado = primNumero + segNumero;

            //5.
            Console.WriteLine(resultado);


            //FIN
            Console.ReadKey();
        }
    }
}
