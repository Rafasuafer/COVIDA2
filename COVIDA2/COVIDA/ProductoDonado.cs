using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class ProductoDonado
	{
		#region Atributos
		private int id;
		private int precio;
		private int cantidad;
		private Producto producto;
		#endregion
		#region Propiedades
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public int Precio
		{
			get { return precio; }
		}
		public Producto Producto
		{
			get { return producto; }
		}
		#endregion
		#region Metodos
		public ProductoDonado(Producto prod, int cant)
		{
			this.producto = prod;
			this.cantidad = cant;
		}

		public bool esValido(){
			bool valido = false;
			if(producto.esValido() && cantidad > 0)
			{
				valido = true;
			}
			return valido;
		}
		#endregion

	}
}
