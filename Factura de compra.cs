using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FacturaCompra
    {
        private string Codigo;

	public string codigo
	{
		get { return Codigo;}
		set { Codigo = value;}
	}
	
    class Factura_de_compra
    {
        
        private string Codigo;
        private string nombre_cliente;
        private DateTime fecha;
        private double total;
        private double iva;
       
        
	public Factura_de_compra(){
        this.Codigo = " ";
        this.nombre_cliente =" ";
        this.fecha = DateTime.Now;
        this.total =double.NaN;
        this.iva = double.NaN;
        }


	public string Nombre_Cliente
	{
		get { return Nombre_Cliente ;}
		set { Nombre_Cliente = value;}
	}
	

	public DateTime Fecha 
	{
		get { return Fecha;}
		set { Fecha = value;}
	}
	

    public double Total
        {
            get { return Total; }
            set { Total = value; }
        }

    public double Iva
    {
            get { return Iva; }
            set { Iva = value; }
        
    }
}

}

    }
