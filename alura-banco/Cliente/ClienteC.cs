using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alura_banco.Cliente
{
    class ClienteC
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;

        public ClienteC(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public bool EhMaiorDeIdade()
        {
            if(this.idade >= 18)
            {
                return true;
            }
            return false;
        }


    }
}
