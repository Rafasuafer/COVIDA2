using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class DonacionEconomica: Donacion
    {
       	#region Atributos		

		#endregion

		#region Propiedades


		#endregion


		#region Metodos
		public DonacionEconomica(): base ()
		{
			this.Fecha = DateTime.Now;
			valor = 0;
		}
		public DonacionEconomica(double monto)
		{
			this.Fecha = DateTime.Now;
			this.valor = monto;
		}
		public DonacionEconomica(double monto, DateTime fecha)
		{
			this.fecha = fecha;
			this.valor = monto;
		}

		public virtual double calcularVale()
        {
            double vale = 0;
            if (valor <= 1000)
            {
                vale = valor * 0.05;
            }
			else if(valor > 1000 && valor <= 2000){
				vale = valor * 0.08;
			}
			else{
				vale = valor * 0.1;
			}

            return vale;
		}

		public override string ToString()
		{
			return "ID: "+ id.ToString() + "Fecha: " + this.fecha.ToShortDateString() + "Monto: " + valor.ToString();
		}

		#endregion
	}
}
