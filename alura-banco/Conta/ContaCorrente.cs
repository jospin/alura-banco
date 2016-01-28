using alura_banco.Cliente;
using System;

namespace alura_banco.Conta
{
    public class ContaCorrente: ContaC
    {
        public ContaCorrente(ClienteC cliente) : base(cliente) { }

        public override void Saque(double number)
        {
            double valor = number + 0.01;
            if (valor >= this.Saldo || valor < 0)
            {
                throw new Exception("Saldo insuficiente");
            }
            this.Saldo -= valor;

        }

    }
}
