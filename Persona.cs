using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBanco
{
	class Persona
	{
		private string nombre;
		private int dni;
		private bool sexo;

		public string pNombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public int pDni
		{
			get { return dni; }
			set { dni = value; }
		}
		public bool pSexo
		{
			get { return sexo; }
			set { sexo = value; }
		}
		public Persona()
		{
			nombre = "";
			dni = 0;
			sexo = false;
		}
		public Persona(string nombre,int dni, bool sexo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.sexo = sexo;
		}
	}
}
