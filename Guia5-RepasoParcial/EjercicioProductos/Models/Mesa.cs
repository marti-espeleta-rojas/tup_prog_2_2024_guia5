using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.Models
{
    public class Mesa : Producto
    {
        double ancho;
        double grosor;

        public Mesa(double precio, double largo, double ancho, double grosor):base(precio, largo)
        {
            this.ancho = ancho;
            this.grosor = grosor;
        }
        public override double Precio()
        {
            double precio = Peso() * precioBase * 1.25;
            return precio;
        }

        public override double Peso()
        {
            double peso = (largo * ancho * grosor) * 0.3;
            return peso;
        }
    }
}
