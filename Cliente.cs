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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {

            FrmMenu a = new FrmMenu();
            a.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void LblCedula_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Guarda los datos que se escribieron en los campos, a las variables previamente escritas
            string CC = TxTC_C.Text;
            string Nombre = TxtNom.Text;
            string Apellido = TxtApeliido.Text;
            string Direccion = TxTDirecci.Text;
            string Telefono = TxTTelefon.Text;
            

            //Se validan los campos// 
            if (Nombre == "" || Apellido == "" || CC == "" || Direccion == "" || Telefono == "")
            {
                //Mensaje emergente en el cual le quiere decir que esta haciendo algo mal
                MessageBox.Show(" Por favor llena todos los campos");
            }

            else
            {
                // Instancia de la clase Empleado y lo almacena en el Procedimiento almacenado 
               Logica.Cliente Registrar_Cliente = new Logica.Cliente();
                // Recoge todos los datos de cada campo del formulario 
                Registrar_Cliente.nombre = TxtNom.Text;
                Registrar_Cliente.apellido = TxtApeliido.Text;
                Registrar_Cliente.Id_cliente= TxTC_C.Text;
                Registrar_Cliente.direccion = TxTDirecci.Text;
                Registrar_Cliente.telefono = TxTTelefon.Text;
                Registrar_Cliente.RegistrarCliente();
                
            }
        }

        private void BtnColsultar_Click(object sender, EventArgs e)
        {
            Logica.Cliente Buscar_Cliente = new Logica.Cliente();
        }

        private void BtnActualiza_Click(object sender, EventArgs e)
        {
                // Instancia de la clase Empleado y lo almacena en el Procedimiento almacenado 
                Logica.Cliente Actualizar_Cliente = new Logica.Cliente();
                // Recoge todos los datos de cada campo del formulario 
                Actualizar_Cliente.nombre = TxtNom.Text;
                Actualizar_Cliente.apellido = TxtApeliido.Text;
                Actualizar_Cliente.Id_cliente=TxTC_C.Text;
                Actualizar_Cliente.direccion = TxTDirecci.Text;
                Actualizar_Cliente.telefono = TxTTelefon.Text;
                Actualizar_Cliente.ActualizarCliente();
            
        }

        private void BtnElimi_Click(object sender, EventArgs e)
        {
            // Instancia de la clase Empleado y lo almacena en el Procedimiento almacenado 
            Logica.Cliente Eliminar_Cliente = new Logica.Cliente();
            //Con el ID del empleado se elimina todo el registro 
            Eliminar_Cliente.EliminarCliente();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rapitiendasDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.ClienteTable.Fill(this.rapitiendasDataSet.Cliente);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClienteTable.FillBy(this.rapitiendasDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

       
        

       
