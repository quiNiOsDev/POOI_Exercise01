using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio01
{
    public partial class FrmRegistroAlumno : Form
    {
        public FrmRegistroAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno(4);

            alumno1.nombres = "Juan";
            alumno2.nombres = "Pedro";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            //obteniendo datos
            venta.numero = txtNumero.Text;
            venta.fecha = DateTime.Parse(txtFecha.Text);
            venta.cliente = txtCliente.Text;
            venta.mueble = txtMueble.Text;
            venta.precio = double.Parse(txtPrecio.Text);

            //asignar datos
            txtDescuento.Text = venta.Descuento().ToString();
            txtPrecioVenta.Text = venta.PrecioVenta().ToString();   




            
        }
    }
}
