using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso
{
    class Conta
    {
        private readonly double _taxa = 5.0;
        public int NumeroConta { get; set; }
        public string NomeTitularConta { get; set; }
        public double Saldo { get; set; }

        //Construtores

        public Conta() { }

        public Conta(string nomeTitularConta, int numeroConta)
        {
            NomeTitularConta = nomeTitularConta;
            NumeroConta = numeroConta;
        }

        public Conta(int numeroConta, string nomeTitularConta, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;
            Saldo = saldo;
        }

        //Metodos
        public double Saque(double saque)
        {
            return Saldo -= saque + _taxa;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public override string ToString()
        {
            return "Conta: "
                    + NumeroConta
                    + ", Titular: "
                    + NomeTitularConta
                    + ", Saldo R$ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
