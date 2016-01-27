using alura_banco.Cliente;
using System;

namespace alura_banco.Conta
{
    public class ContaPoupanca : ContaC
    {

        public ContaPoupanca(ClienteC cliente) : base(cliente) { }

        public override void Saque(double saque)
        {
            double valor = saque + 0.10;

            if (!Titular.EhMaiorDeIdade && valor > 200)
            {
                throw new Exception("Saque de menor de idade limitado à 200");
            }
            if (valor >= this.Saldo || valor < 0)
            {
                throw new Exception("Saldo insuficiente");
            }
            this.Saldo -= valor;

        }

        public void CalculaInvestimento()
        {
            this.Saldo += this.Saldo * 0.01;

        }
    }
}
