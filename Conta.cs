using System;
using System.Globalization;

namespace Couse
{
    public  class Conta
    {
        public int Numero;
        public string NomeTitular;
        public double Taxa = 5.0;
        public double Saldo;
        public double SaldoRestante;
        public double SaldoDescontado;

        public void EfetuarDeposito(double valor)
        {
            this.Saldo = this.Saldo + valor;
        }
        public void EfetuarNovoDeposito(double valor)
        {
            this.SaldoRestante = this.Saldo + valor;
        }

        public void Desconto(double valorDescontado)
        {
            this.SaldoDescontado = SaldoRestante - valorDescontado - Taxa;

        }


        public override string ToString()
        {
            return "Conta: "
            + Numero  
            + ", Titular: "
            + NomeTitular
            + " Seu depósito foi de: "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture)
            + ", Saldo: "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }    

    }
}
