using System;

namespace alura_banco.Cliente
{
    public class ContaC
    {
        // Declaração de Properties
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public ClienteC Titular { get; protected set; }
        public double Saldo { get; protected set; }

        public ContaC(ClienteC cliente)
        {
            this.Titular = cliente;
        }

        public virtual void Saque(double valor)
        {

            if (!Titular.EhMaiorDeIdade && valor > 200)
            {
                throw new Exception("Saque de menor de idade limitado à 200");
            }
            if(valor >= this.Saldo || valor < 0)
            {
                throw new Exception("Saldo insuficiente");
            }
            this.Saldo -= valor;
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
                this.Saldo += valor;
            } else
            {
                throw new Exception("Valor do depósito deve ser positivo");
            }
        }

    }
}
