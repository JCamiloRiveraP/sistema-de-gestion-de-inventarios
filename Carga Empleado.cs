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
    public partial class Carga_Empleado : Form
    {
        public Carga_Empleado()
        {
            InitializeComponent();
        }
        public void fr_prbar_()
        {
            PgbCargaEmplea.Increment(1);
            label1.Text = PgbCargaEmplea.Value.ToString() + "%";
            if (PgbCargaEmplea.Value==PgbCargaEmplea.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Bienvenido Empleado");
                    this.Hide();
                FrmMenuEmpleado ff= new FrmMenuEmpleado();
                ff.Show();
            }
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr_prbar_();
        }
    }
}
