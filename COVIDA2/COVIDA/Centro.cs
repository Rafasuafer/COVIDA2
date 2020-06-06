using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Centro
    {
        #region Atributos
        private int id;
		private static int ultimoId = 0;
        private string nombre;
		private List<Voluntario> voluntarios;
        private string direccion;
		private List<DonacionEconomica> stock;

		#endregion

		#region Propiedades
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Nombre
        {
            get { return nombre; }
		}
		public int cantidadVol
		{
			get { return voluntarios.Count; }
		}
		public List<Voluntario> Voluntarios
		{
			get { return voluntarios; }
			set { voluntarios = value; }
		}
		public string Direccion
        {
            get { return direccion; }
        }

        public List<DonacionEconomica> Stock
        {
            get { return stock; }
        }
        #endregion

        #region Metodos
        public Centro(string nombre, string direccion)
        {
			this.id = ultimoId++;
            this.nombre = nombre.ToUpper();
            this.direccion = direccion;
            this.voluntarios = new List<Voluntario>();
            this.stock = new List<DonacionEconomica>();
        }

		public bool sumarVoluntario(Voluntario nVol){
			bool added = false;
			if (!registrado(nVol))
			{
				voluntarios.Add(nVol);
				added = true;
			}

			return added;
		}

		public bool registrado(Voluntario vol){
			bool encontrado = false;
			int i = 0;
			while (!encontrado & i < voluntarios.Count)
			{
				if (voluntarios[i].Ci == vol.Ci)
				{
					encontrado = true;
				}
				i++;
			}
			return encontrado;
		}
		public bool registrado(int ci)
		{
			bool encontrado = false;
			int i = 0;
			while (!encontrado & i < voluntarios.Count)
			{
				if (voluntarios[i].Ci == ci)
				{
					encontrado = true;
				}
				i++;
			}
			return encontrado;
		}

		public override string ToString()
		{
			return "Id: " + this.id + " | Centro: " + this.nombre + " | Direccion: "+ this.direccion;
		}

		public string getStrVoluntarios(){
			string strVoluntarios = "";
			if (voluntarios.Count > 0)
			{
				foreach (var voluntario in voluntarios)
				{
					strVoluntarios += voluntario.ToString() + "\n";
				}
			}
			else
			{
				strVoluntarios = "# No hay voluntarios registrados.";
			}
			return strVoluntarios;
		}
		
		public string getStrDonacionesFecha(DateTime fecha){
			string strDonaciones = "# NO HAY DONACIONES";

			if (stock.Count > 0)
			{
				int cantidad = 0;
				foreach (DonacionEconomica donacion in stock)
				{
					if (donacion.Fecha.ToShortDateString() == fecha.ToShortDateString())
					{
						cantidad++;
					}
				}
				strDonaciones = "donaciones recibidas a la fecha: " + cantidad + "\n";
			}

			return strDonaciones;
		}

		public void recibirDonacion(DonacionEconomica donacion){
			stock.Add(donacion);
		}

        #endregion
    }
}
