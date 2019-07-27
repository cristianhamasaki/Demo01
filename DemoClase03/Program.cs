using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    enum DiasDeSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    class Program
    {
        static void Main(string[] args)
        {
            DiasDeSemana diaElegido = DiasDeSemana.Miercoles;

            switch (diaElegido)
            {
                case DiasDeSemana.Lunes:
                    Console.WriteLine("Mila con fritas");
                    break;
                case DiasDeSemana.Miercoles:
                    Console.WriteLine("Ravioles con salsa Bolognesa");
                    break;
                case DiasDeSemana.Viernes:
                    Console.WriteLine("Ensalada Cesar");
                    break;
                default:
                    Console.WriteLine("No hay menu para este día");
                    break;
            }

            /*
            string lunes = "Lunes";
            string viernes = "Viernes";
            string miercoles = "Miercoles";

            string diaSeleccionado = "Miercoles";

            if (diaSeleccionado == lunes)
            {
                Console.WriteLine("Mila con fritas");
            }
            else if (diaSeleccionado == miercoles)
            {
                Console.WriteLine("Ravioles con salsa Bolognesa");
            }
            else if (diaSeleccionado == viernes)
            {
                Console.WriteLine("Ensalada Cesar");
            }
            else 
            {
                Console.WriteLine("No hay menu para este día");
            }
            */
        }
    }
}
