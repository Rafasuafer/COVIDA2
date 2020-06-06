using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{	
	class Program
	{ 
		static void Main(string[] args)
		{
			Menu menu = new Menu();
			menu.bienvenida();
			

			menu.inicio();
			
			Console.ReadKey();
		}
	}
}
