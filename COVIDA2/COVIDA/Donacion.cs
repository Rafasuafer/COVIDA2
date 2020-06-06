using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Donacion
    {

        public enum TipoDon
        {
			na = 0,
            economica = 1,
            producto = 2

        }
		#region Atributos
		protected int id;
		protected DateTime fecha;
		protected TipoDon tipoDon;
		protected double valor;
		#endregion

		#region Propiedades
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public DateTime Fecha
        {
            get { return fecha; }
			set { fecha = value; }
        }
		public double Valor
		{
			set { valor = value; }
			get { return valor; }
		}
		#endregion


		#region Metodos
		public Donacion()
        {
			this.fecha = new DateTime();
			this.valor = 0;
			this.tipoDon = 0;
        }

		public virtual bool validarDonacion(){
			bool esValida = false;
			if(valor > 0){
				esValida = true;
			}
			return esValida;
		}

        #endregion
    }
}