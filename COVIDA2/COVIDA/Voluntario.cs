using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Voluntario
    {

        #region Atributos
        private string nombre;
        private int ci;
        private int telefono;
        private DateTime fechaNac;

        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
        }
        public int Ci
        {
            get { return ci; }
        }
        public int Telefono
        {
            get { return telefono; }
        }
        public DateTime FechaNac
        {
            get { return fechaNac; }
        }

        #endregion

        #region Metodos

        public Voluntario(string nombre, int ci, int telefono, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.ci = ci;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
        }


		public override string ToString()
		{
			return "Voluntario: " + this.nombre + " | CI: " + this.ci;
		}
		#endregion
	}
}
