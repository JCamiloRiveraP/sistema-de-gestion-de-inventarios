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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {

            FrmMenu a = new FrmMenu();
            a.Show();
            this.Hide();
        
        }
        }
       

        }

