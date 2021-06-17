using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBanco
{
	class Cliente:Persona
	{
		private int codigoClte;
		private Cuenta cuenta;

		public Cuenta pCuenta
		{
			get { return cuenta; }
			set { cuenta = value; }
		}

		public int pCodigoClte
		{
			get { return codigoClte; }
			set { codigoClte = value; }
		}

		public Cliente():base()
		{
			codigoClte = 0;
			cuenta = null;
		}
		public Cliente(int codigoClte, Cuenta cuenta, string nombre, int dni, bool sexo) :base(nombre,dni,sexo)
		{
			this.codigoClte = codigoClte;
			this.cuenta = cuenta;

		}
	}
}
