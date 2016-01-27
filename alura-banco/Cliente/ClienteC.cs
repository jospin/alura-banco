using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alura_banco.Cliente
{
    public class ClienteC
    {
        // Declarações de Properties
        public string Nome { get; private set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; private set; }

        public ClienteC(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public bool EhMaiorDeIdade
        {
            get
            {
                return this.Idade >= 18;
            }
        }
    }
}
