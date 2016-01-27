using alura_banco.Cliente;
using System;

namespace alura_banco.Conta
{
    class Totalizador
    {
        public Double Total { get; private set; }

        public void Adiciona(ContaC conta)
        {
            this.Total += conta.Saldo;
        }
    }
}
