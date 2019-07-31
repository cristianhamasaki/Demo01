using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fPedida;
            DateTime fActual;

            do
            {
                Console.WriteLine("Ingresar fecha: ");
                string fechaPedida = Console.ReadLine();

                //Se debe convertir la fecha pedida por consola
                //para realizar el cálculo entre ellas

                //Sólo para fecha pedida se debe convertir 
                //Esto es lo que se escribe por consola

                //Nota Importante: Cuando llega la fecha a este paso llega con formato (mm/dd/yyyy)
                fPedida = Convert.ToDateTime(fechaPedida);

                //Esto setea la fecha actual
                //el DateTime.Now es algo que el framework nos ofrece
                //para no tener que realizar ningún tipo de acción para saber la fecha actual

                //Nota Importante: el DateTime.now aplica el formato (mm/dd/yyyy)
                fActual = DateTime.Now;

                if (fPedida < fActual)
                {
                    Console.WriteLine("La fecha ingresada es anterior a la actual.");
                }

            } while (fPedida < fActual);
            
            TimeSpan cantidadFaltantes = fPedida - fActual;

            Console.WriteLine($"Cantidad de días faltantes: {cantidadFaltantes.TotalDays}");

            Console.ReadKey();
        }
    }
}
