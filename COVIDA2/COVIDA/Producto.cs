using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio


{
    public class Producto
    {

        public enum TipoProd
        {
            bebida = 1,
            alimentoNoPerecedero = 2,
            alimentoFresco = 3,
            productoLimpieza = 4,
            productoHigiene = 5,
            noExiste = 0

        }
        #region Atributos
        private int id;
        private string nombre;
        private int peso;
        private int precio; 
        private static TipoProd tipoProd;
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
		}
		public int Precio
		{
			get { return precio; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public TipoProd Tipo
		{
			get { return tipoProd; }
		}

		#endregion


		#region Metodos
		public Producto(string nombre, int peso, int precio, TipoProd tipoProd)
        {
            this.nombre = nombre.ToUpper();
            this.peso = peso;
            this.precio = precio;
        }

		public override string ToString()
		{
			return "Producto: " + this.nombre + " | Precio Unitario: " + this.precio;
		}


		public bool esValido(){
			bool valido = false;
			if (this.precio > 0 && this.peso > 0)
			{
				valido = true;
			}
			return valido;
		}
		#endregion
	}
}
