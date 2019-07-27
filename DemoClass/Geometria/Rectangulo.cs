using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass.Geometria
{
    class Rectangulo
    {
        public double Altura;
        public double Base;

        public double CalcSup()
        {
            double result = Base * Altura;
            return result;
        }
    }
}
