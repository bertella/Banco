using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBanco
{
	class Banco
	{
		private Cliente[] clientes;

		public Cliente[] pClientes
		{
			get { return clientes; }
			set { clientes = value; }
		}

		public Banco()
		{
			clientes = new Cliente[5];
		}
		public Banco(int cantidad)
		{
			clientes = new Cliente[cantidad];
		}

		public void nuevoCliente(Cliente oCliente)
		{
			for (int i = 0; i < clientes.Length; i++)
			{
				if (clientes[i] == null)
				{
					clientes[i] = oCliente;
					break;
				}
			}
		}
	}
}
