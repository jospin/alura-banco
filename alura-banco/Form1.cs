using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using alura_banco.Cliente;

namespace alura_banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            ContaC contaL = new ContaC();
            contaL.numero = 1;
            contaL.titular = new ClienteC("Lucien", 37);
            contaL.Deposita(2000);
            */

            ContaC contaC = new ContaC();
            contaC.numero = 1;
            contaC.titular = new ClienteC("Cristina", 17);
            contaC.Deposita(0);
            bool maior = contaC.titular.EhMaiorDeIdade();
            if (!maior)
            {
                MessageBox.Show("Cristina não é maior de idade");
            }
            try
            {
                contaC.Saque(150);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na operação: " + ex.Message);
            }
            
            MessageBox.Show("Conta cliente: " + contaC.titular.nome);
            //MessageBox.Show("Saldo após o saque: " + contaL.saldo);
            MessageBox.Show("Saldo após o transferência: " + contaC.saldo);


        }
    }
}
