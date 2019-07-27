using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 5)
            {
                Console.WriteLine("Iteración: " + contador);
                contador = contador + 1; 
                //contador++;
            }
            Console.ReadKey();
        }
    }
}
