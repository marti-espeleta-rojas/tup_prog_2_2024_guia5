using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.Models
{
    public class Cliente
    {
        string nombre;
        string direccion;
        public Cliente(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
        public override string ToString()
        {
            return $"{nombre} - {direccion}";
        }
    }
}
