using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVIDA
{
	class Sistema
    
	{
		private List<Producto> productos;
		private List<Donacion> donaciones;
		private List<Centro> centros;
		private List<Voluntario> voluntarios;

		public List<Producto> Productos
		{
			set { productos = value; }
			get { return productos; }
		}
		public List<Donacion> Donaciones
		{
			set { donaciones = value; }
			get { return donaciones; }
		}
		public List<Centro> Centros
		{
			set { centros = value; }
			get { return centros; }
		}

		public void Data(){

			productos = new List<Producto>();
			centros = new List<Centro>();
			donaciones = new List<Donacion>();
			precarga();
		}

		public void precarga(){
			#region PRODUCTOS
			nuevoProducto(new Producto("Papa", 1, 35, Producto.TipoProd.alimentoFresco));
			nuevoProducto(new Producto("Cebolla", 1, 45, Producto.TipoProd.alimentoFresco));
			nuevoProducto(new Producto("Kiwi", 1, 235, Producto.TipoProd.alimentoFresco));
			nuevoProducto(new Producto("Hipoclorito", 1, 90, Producto.TipoProd.productoLimpieza));
			nuevoProducto(new Producto("Desinfectante", 1, 130, Producto.TipoProd.productoLimpieza));
			nuevoProducto(new Producto("Alcohol en gel", 1, 250, Producto.TipoProd.productoHigiene));
			nuevoProducto(new Producto("Jabon", 1, 60, Producto.TipoProd.productoHigiene));
			nuevoProducto(new Producto("Leche", 1, 29, Producto.TipoProd.bebida));
			nuevoProducto(new Producto("Leche en polvo", 1, 110, Producto.TipoProd.alimentoNoPerecedero));
			nuevoProducto(new Producto("Lata choclo", 1, 30, Producto.TipoProd.alimentoNoPerecedero));
			nuevoProducto(new Producto("Lata arvejas", 1, 30, Producto.TipoProd.alimentoNoPerecedero));
			nuevoProducto(new Producto("Coquita en botella de vidrio :)", 1, 110, Producto.TipoProd.bebida));
			#endregion

			#region CENTROS
			nuevoCentro(new Centro("Shopping", "Calle 13"));
			nuevoCentro(new Centro("Hope", "18 de Julio y Bv.Artigas"));
			nuevoCentro(new Centro("Blandengues", "Av.Italia y L.A. Herrera"));
			#endregion

			#region VOLUNTARIOS

			#endregion
		}


		public void nuevoProducto(Producto nProd){
			nProd.Id = productos.Count;
			productos.Add(nProd);
		}

		public void nuevoCentro(Centro nCen)
		{
			nCen.Id = centros.Count;
			centros.Add(nCen);
		}

		public void nuevoVoluntario(Voluntario nVol)
		{
			bool existe = false;
			int ite = 0;
			while (ite < voluntarios.Count && !existe){
				if (nVol.Ci == voluntarios[ite].Ci){
					existe = true;
				}

				ite++;
			}

			if(!existe){ 
				voluntarios.Add(nVol);
			}
			else{
				Console.WriteLine("# ERROR: Voluntario ya existente.");
			}
		}
	}
}
