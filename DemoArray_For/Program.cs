using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArray_For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = { "Enero","Febrero","Marzo", "Abril", "Mayo","Junio" };

            Console.WriteLine("Con el for:");

            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i]);
            }

            Console.WriteLine("Con el foreach:");

            foreach(string mes in s1.Reverse())
            {
                Console.WriteLine(mes);
            }

            Console.WriteLine("Finalizado");

            Console.ReadKey();


        }
    }
}
