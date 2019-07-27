using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chinoArray = { 5, 2, 4, 10, 13, 20, 19 };
            int sumatoria = 0;
            int sumaPar = 0;
            foreach (int item in chinoArray)
            {
                sumatoria = sumatoria + item;
                if (item % 2 == 0)
                {
                    sumaPar = sumaPar + item;
                }
                Console.WriteLine(item);
                Convert.ToInt32("123");

            }
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Suma Par: " + sumaPar);


            //int sumaImpar = 0;
            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i%2 != 0)
            //    {
            //        sumaImpar += i;
            //    }
            //}

            //for (int i = 1; i <= 100; i+=2)
            //{
            //    sumaImpar += i;
            //}

            //Console.WriteLine(sumaImpar);

            Console.ReadKey();
        }
    }
}
