using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alura_banco.Cliente;

namespace alura_banco.Cliente
{
    class ContaC
    {
        public int agencia;
        public int numero;
        public ClienteC titular;
        public double saldo;

        public void Saque(double valor)
        {
            bool naoLimitaSaque = titular.EhMaiorDeIdade();
            if (!naoLimitaSaque && valor > 200)
            {
                throw new Exception("Saque de menor de idade limitado à 200");
            }
            if(valor >= this.saldo || valor < 0)
            {
                throw new Exception("Saldo insuficiente");
            }
            this.saldo -= valor;
        }

        public void Transfere(double valor, ContaC destino)
        {
            Saque(valor);
            destino.Deposita(valor);
        }

        public void Deposita(double valor)
        {
            if(valor >= 0)
            {
                this.saldo += valor;
            }
        }

    }
}
