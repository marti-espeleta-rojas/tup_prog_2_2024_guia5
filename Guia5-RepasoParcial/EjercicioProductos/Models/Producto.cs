using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.Models
{
    public abstract class Producto : IComparable
    {
        protected double precioBase;
        protected double largo;
        int codigo;
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public Producto(double precio, double largo)
        {
            precioBase = precio;
            this.largo = largo;
        }

        public abstract double Precio();
        public abstract double Peso();

        public int CompareTo(object obj)
        {
            Producto p = obj as Producto;
            if (p != null)
            {
                return Codigo.CompareTo(p.Codigo);
            }
            return 1;
        }
    }
}
