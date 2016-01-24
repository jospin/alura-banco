using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alura_banco.Conta
{
    class ContaC
    {
        public int agencia;
        public int numero;
        public string titular;
        public double saldo;
        public string cpf;

        public void Saque(double valor)
        {
            if(valor <= this.saldo && valor >= 0)
            {
                this.saldo -= valor;
            }
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
