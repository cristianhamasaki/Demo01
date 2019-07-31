using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_OOP_Punto8
{
    public class Producto
    {
        int _id;
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        string _nombre;
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set {
                this._nombre = value;
            }
        }

        bool _haystock;
        public bool HayStock
        {
            get
            {
                return this._haystock;
            }
            set
            {
                this._haystock = value;
            }
        }

        float _precio;
        public float Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }

        int _cantidad;
        public int Cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                this._cantidad = value;
            }
        }
    }
}
