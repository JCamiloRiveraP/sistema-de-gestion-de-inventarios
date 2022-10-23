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
    public partial class FrmCarga : Form
    {
        public FrmCarga()
        {
            InitializeComponent();
        }
        public void fr_prbar_()
        {
            PgbCarga.Increment(1);
            label1.Text = PgbCarga.Value.ToString() + "%";
            if (PgbCarga.Value == PgbCarga.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Bienvenido Administrador");
                this.Hide();
                FrmMenu ff = new FrmMenu();
                ff.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr_prbar_();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
