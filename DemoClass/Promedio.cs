using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    class Promedio
    {
        public double CalcularPromedio(double[] notas)
        {
            double suma = 0;
            foreach(double nota in notas)
            {
                suma += nota;
            }
            return suma / notas.Length;
        }
    }
}
