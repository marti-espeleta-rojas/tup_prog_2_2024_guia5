using EjercicioProductos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto p = null;
        Presupuesto presu = null;

        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            presu = new Presupuesto(tbNombre.Text, tbDireccion.Text);
            btnIniciarPresupuesto.Enabled = false;
            tbNombre.Clear();
            tbDireccion.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(tbPrecio.Text);
            double ancho = Convert.ToDouble(tbAncho.Text);
            double grosor = Convert.ToDouble(tbGrosor.Text);
            double largo = Convert.ToDouble(tbLargo.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);
            if(ancho!=0 && grosor != 0)
            {
                p = new Mesa(precio, largo, ancho, grosor);
            }
            else
            {
                p = new Banco(precio, largo);
            }
            p.Codigo = codigo;
            presu.AgregarProducto(p);
            cbxProductos.Items.Add(p.Codigo);
            tbAncho.Clear();
            tbCodigo.Clear();
            tbPrecio.Clear();
            tbGrosor.Clear();
            tbLargo.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cbxProductos.Items.Remove(presu.QuitarProducto(Convert.ToInt32(cbxProductos.Text)));
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            btnIniciarPresupuesto.Enabled = true;
            MessageBox.Show($"Precio Total: {presu.Precio}");
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            Resumen res = new Resumen();
            string[] nota = presu.Resumen();
            for (int i = 0; i < nota.Length; i++)
            {
                string o = nota[i];
                res.lbxResumen.Items.Add(o);
            }
            res.Show();
        }
    }
}
