using alura_banco.Cliente;
using System;

namespace alura_banco.Banco
{
    public class BancoB
    {
        private ContaC[] Contas = new ContaC[10];
        private int quantidade = 0;

        public void Adiciona(ContaC conta)
        {
            if(this.quantidade >= 9)
            {
                throw new Exception("Quantidade de contas superadas");
            }
            this.Contas[this.quantidade] = conta;
            this.quantidade++;
        }

    }
}
