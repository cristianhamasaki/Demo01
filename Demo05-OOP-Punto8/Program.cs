using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_OOP_Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Crear la clase Producto
            //2. crearle las propiedades
            //3. Creación de método de obtención de productos

            List<Producto> lstProductos = ObtenerProductos();
            
            for (int i = 0; i <= lstProductos.Count - 1; i++)
            {
                Console.WriteLine($"{lstProductos[i].ID}. {lstProductos[i].Nombre} - {lstProductos[i].Precio}");
            }

            Console.WriteLine("Ingresar número de uno de los productos: ");
            string numeroElegido = Console.ReadLine();

            Producto productoElegido = ObtenerProductoSeleccionado(lstProductos, Convert.ToInt32(numeroElegido));
            productoElegido.Precio = 100000.0F;

            Console.WriteLine($"ID: {productoElegido.ID}");
            Console.WriteLine($"Nombre: {productoElegido.Nombre}");
            Console.WriteLine($"Precio: {productoElegido.Precio}");

            Console.ReadKey();
        }

        //Simulación de datos provenientes de una BD
        private static List<Producto> ObtenerProductos()
        {
            List<Producto> lstProductos = new List<Producto>();

            Producto productoUno = new Producto();
            productoUno.ID = 1;
            productoUno.Nombre = "Cerveza Brahma";
            productoUno.HayStock = true;
            productoUno.Precio = 50.0F;
            productoUno.Cantidad = 20;

            Producto productoDos = new Producto();
            productoDos.ID = 2;
            productoDos.Nombre = "Yerba";
            productoDos.HayStock = false;
            productoDos.Precio = 80.5F;
            productoDos.Cantidad = 2;

            Producto productoTres = new Producto();
            productoTres.ID = 3;
            productoTres.Nombre = "Don Satur";
            productoTres.HayStock = true;
            productoTres.Precio = 30.0F;
            productoTres.Cantidad = 4;

            lstProductos.Add(productoUno);
            lstProductos.Add(productoDos);
            lstProductos.Add(productoTres);

            return lstProductos;
        }

        private static Producto ObtenerProductoSeleccionado(List<Producto> lstProductos, int idElegido)
        {
            //Se le asigna el producto elegido a la variable auxiliar
            Producto prodAuxiliar = new Producto();

            foreach (Producto prod in lstProductos)
            {
                if (prod.ID == idElegido)
                {
                    prodAuxiliar = prod;
                    break;
                }
            }

            return prodAuxiliar;
        }
    }
}
