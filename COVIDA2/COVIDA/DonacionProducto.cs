using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class DonacionProducto : Donacion
    {
        
		#region Atributos
		private List<ProductoDonado> productos;
		
		#endregion

		#region Propiedades

		public List<ProductoDonado> Productos{
			set { productos = value; }
			get { return productos; }
		}

		#endregion


		#region Metodos
		public DonacionProducto(List<ProductoDonado> productos, DateTime fecha) : base()
		{
			this.productos = productos;
			base.Fecha = fecha;
			foreach (ProductoDonado prod in productos)
			{
				Valor += prod.Precio;
			}
		}
		public DonacionProducto(List<ProductoDonado> productos) : base()
        {
			base.Fecha = DateTime.Now;
			this.productos = productos;
        }
        
        #endregion
    }
}
