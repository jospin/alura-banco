using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using alura_banco.Conta;

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
            ContaC conta = new ContaC();
            conta.numero = 1;
            conta.titular = "Lucien";
            conta.saldo = 2000;

            MessageBox.Show("Conta é: " + conta.numero + " - " + conta.titular);
        }
    }
}
