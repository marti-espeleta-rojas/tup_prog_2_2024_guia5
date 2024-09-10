using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.Models
{
    public class Presupuesto
    {
        public double Precio { get; set; }
        ArrayList listaProductos = new ArrayList();
        Cliente cli = null;
        public Presupuesto(string nombre, string direccion)
        {
            cli = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto unProducto)
        {
            Precio += unProducto.Precio();
            listaProductos.Add(unProducto);
        }

        public bool QuitarProducto(int codigo)
        {
            Producto p = BuscarProducto(codigo);
            if (listaProductos.Contains(p) == true)
            {
                listaProductos.Remove(p);
                return true;
            }
            return false;
        }

        private Producto BuscarProducto(int codigo)
        {
            Producto p = null;
            listaProductos.Sort();
            int idx=listaProductos.BinarySearch(codigo);
            if (idx >= 0)
            {
                p = (Producto)listaProductos[idx];
            }
            return p;
        }

        public string[] Resumen()
        {
            string[] resus = new string[listaProductos.Count];
            resus[0] = $"{cli.ToString()}";
            for(int i = 1; i < resus.Length; i++)
            {
                Producto p = (Producto)listaProductos[i];
                resus[i] = $"Producto {i} - Precio: {p.Precio()} - Peso: {p.Peso()}";
            }
            return resus;
        }
    }
}
