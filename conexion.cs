using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Proyecto_Sena
{
    public class conexion
    {
        public SqlConnection conection;
        
        public string cadena = "Data Source=PULIDORIVERA\\SQLEXPRESS;Initial Catalog=Rapitiendas;Integrated Security=True";
        
        public void abrir()
        {
            this.cerrar();
            conection = new SqlConnection(cadena);
            conection.Open();
        }
               
        public void cerrar()
        {
            conection = new SqlConnection(cadena);
            conection.Close();
        }
    }
}
            
        
   

