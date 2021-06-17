using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBanco
{
	class Cuenta
	{
		private double limiteCuenta;
		private int nroCuenta;

		public int pNroCuenta
		{
			get { return nroCuenta; }
			set { nroCuenta = value; }
		}
		public double pLimiteCuenta
		{
			get { return limiteCuenta; }
			set { limiteCuenta = value; }
		}

		private double saldo;

		public double pSaldo
		{
			get { return saldo; }
			set { saldo = value; }
		}
		
		private int tipoCuenta;

		public int ptipoCuenta
		{
			get { return tipoCuenta; }
			set { tipoCuenta = value; }
		}


		public Cuenta()
		{
			limiteCuenta = 0;
			saldo = 0;
			tipoCuenta = 0;
			nroCuenta = 0;
		}

		public Cuenta(double limitCta,int nroCta,double saldo,int tipoCta)
		{
			limiteCuenta = limitCta;
			this.saldo = saldo;
			tipoCuenta = tipoCta;
			nroCuenta = nroCta;

		}

	}
}
