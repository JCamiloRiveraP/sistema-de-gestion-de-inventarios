using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenuEmpleado : Form
    {
        public FrmMenuEmpleado()
        {
            InitializeComponent();

        }

        private void BtnFacturaVenta_Click(object sender, EventArgs e)
        {
            FrmFacturaVenta a = new FrmFacturaVenta();
            a.Show();
            this.Hide();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto a = new FrmProducto();
            a.Show();
            this.Hide();
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin a = new FrmLogin();
            a.Show();
            this.Hide();
        }

        private void HoraYDia_Click(object sender, EventArgs e)
        {
            HoraYDia.Text = DateTime.Now.ToShortTimeString();
        }

        private void BtnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            FrmLogin a = new FrmLogin();
            a.Show();
            this.Hide();
        }

        private void LblSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            {
                FrmEmpleado a = new FrmEmpleado();
                a.Show();
                this.Hide();
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            {
                FrmCliente a = new FrmCliente();
                a.Show();
                this.Hide();
            }
        }

        private void BtnFacturaCompra_Click(object sender, EventArgs e)
        {
            {
                FrmFacturaCompra a = new FrmFacturaCompra();
                a.Show();
                this.Hide();
            }
        }

        private void BtnFacturaVenta_Click_1(object sender, EventArgs e)
        {
            {
               FrmFacturaVenta a = new FrmFacturaVenta();
                a.Show();
                this.Hide();
            }
        }

        private void BtnProducto_Click_1(object sender, EventArgs e)
        {
            {
                FrmProducto a = new FrmProducto();
                a.Show();
                this.Hide();
            }
        }
    }
}
