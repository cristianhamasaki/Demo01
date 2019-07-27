using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass.Geometria
{
    class Triangulo
    {
        public double Altura;
        public double Base;

        public double CalcSup()
        {
            double result = Base * Altura / 2;
            return result;
        }
    }
}
