using System;
using System.Windows.Forms;
using alura_banco.Cliente;
using alura_banco.Conta;

namespace alura_banco
{
    public partial class Form1 : Form
    {
        private ContaC conta;
        private ContaC[] contasCadastro = new ContaC[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ClienteC titular = new ClienteC("Cristina", 19) { Rg = "10.100.100-9", Cpf = "270.444.239-99" };
            this.conta = new ContaPoupanca(titular);
            this.conta.Numero = 1;
            this.conta.Agencia = 12;
            this.MostraConta();

            ClienteC t1 = new ClienteC("Gabriel", 14);
            this.contasCadastro[0] = new ContaCorrente(t1);
            ClienteC t2 = new ClienteC("Caroline", 8);
            this.contasCadastro[1] = new ContaPoupanca(t2);
            ClienteC t3 = new ClienteC("Letícia", 10);
            this.contasCadastro[2] = new ContaPoupanca(t3);
            ClienteC t4 = new ClienteC("Lucien", 37);
            this.contasCadastro[3] = new ContaCorrente(t4);

            for (int i=0; i < this.contasCadastro.Length; i++)
            {
                comboDestinos.Items.Add("Titualr: " + this.contasCadastro[i].Titular.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void saqueButton_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textSaque.Text);
            try
            {
                this.conta.Saque(valor);
                this.MostraConta();
                textSaque.Text = "";
            } catch(Exception ex)
            {
                MessageBox.Show("Operação não realizada: " + ex.Message);
            }            
        }

        private void depositoButton_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textDeposito.Text);
            try
            {
                this.conta.Deposita(valor);
                this.MostraConta();
                textDeposito.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operação não realizada: " + ex.Message);
            }
        }

        private void MostraConta()
        {
            textAgencia.Text = Convert.ToString(this.conta.Agencia);
            textNumero.Text = Convert.ToString(this.conta.Numero);
            textCliente.Text = this.conta.Titular.Nome;
            textCpf.Text = this.conta.Titular.Cpf;
            textSaldo.Text = Convert.ToString(this.conta.Saldo);

        }
    }
}
