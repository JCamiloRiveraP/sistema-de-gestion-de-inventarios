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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LblIngresar_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;
            string tipousuario;

            usuario = TxtUsuario.Text;
            contrasena = TxtContrasena.Text;
            tipousuario = CbTipoUsuario.Text;

            if (usuario == "Administrador" && contrasena == "123" && tipousuario =="Administrador")
            {
                FrmCarga a = new FrmCarga();
                a.Show();
                this.Hide();
            }
            else if (usuario == "Empleado" && contrasena == "456" && tipousuario == "Empleado")
            {
                Carga_Empleado a = new Carga_Empleado();
                a.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Su usuario y/o contraseña son invalidos", "Error");
                TxtUsuario.Clear();
                TxtContrasena.Clear();
                TxtUsuario.Focus();
                CbTipoUsuario.Text = "";

            }
            {
              
            }
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

    }
}