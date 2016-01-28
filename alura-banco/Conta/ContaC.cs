using System;

namespace alura_banco.Cliente
{
    public abstract class ContaC
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

        public abstract void Saque(double valor);

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
