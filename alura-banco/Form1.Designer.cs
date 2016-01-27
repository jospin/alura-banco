namespace alura_banco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Saque = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAgencia = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDeposito = new System.Windows.Forms.TextBox();
            this.depositoButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textSaque = new System.Windows.Forms.TextBox();
            this.saqueButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboDestinos = new System.Windows.Forms.ComboBox();
            this.transferenciaButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Saque
            // 
            this.Saque.Location = new System.Drawing.Point(348, 91);
            this.Saque.Name = "Saque";
            this.Saque.Size = new System.Drawing.Size(75, 23);
            this.Saque.TabIndex = 0;
            this.Saque.Text = "button1";
            this.Saque.UseVisualStyleBackColor = true;
            this.Saque.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSaldo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCpf);
            this.groupBox1.Controls.Add(this.Saque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCliente);
            this.groupBox1.Controls.Add(this.cliente);
            this.groupBox1.Controls.Add(this.textAgencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(70, 20);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(80, 20);
            this.textNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agencia";
            // 
            // textAgencia
            // 
            this.textAgencia.Location = new System.Drawing.Point(304, 19);
            this.textAgencia.Name = "textAgencia";
            this.textAgencia.Size = new System.Drawing.Size(120, 20);
            this.textAgencia.TabIndex = 3;
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Location = new System.Drawing.Point(7, 45);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(39, 13);
            this.cliente.TabIndex = 4;
            this.cliente.Text = "Cliente";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(70, 45);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(161, 20);
            this.textCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(304, 45);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(119, 20);
            this.textCpf.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saldo";
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(70, 70);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transferenciaButton);
            this.groupBox2.Controls.Add(this.comboDestinos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.saqueButton);
            this.groupBox2.Controls.Add(this.textSaque);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.depositoButton);
            this.groupBox2.Controls.Add(this.textDeposito);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bloco de operação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor";
            // 
            // textDeposito
            // 
            this.textDeposito.Location = new System.Drawing.Point(57, 20);
            this.textDeposito.Name = "textDeposito";
            this.textDeposito.Size = new System.Drawing.Size(113, 20);
            this.textDeposito.TabIndex = 1;
            // 
            // depositoButton
            // 
            this.depositoButton.Location = new System.Drawing.Point(342, 15);
            this.depositoButton.Name = "depositoButton";
            this.depositoButton.Size = new System.Drawing.Size(81, 23);
            this.depositoButton.TabIndex = 2;
            this.depositoButton.Text = "Depósito";
            this.depositoButton.UseVisualStyleBackColor = true;
            this.depositoButton.Click += new System.EventHandler(this.depositoButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor";
            // 
            // textSaque
            // 
            this.textSaque.Location = new System.Drawing.Point(57, 46);
            this.textSaque.Name = "textSaque";
            this.textSaque.Size = new System.Drawing.Size(113, 20);
            this.textSaque.TabIndex = 4;
            // 
            // saqueButton
            // 
            this.saqueButton.Location = new System.Drawing.Point(342, 44);
            this.saqueButton.Name = "saqueButton";
            this.saqueButton.Size = new System.Drawing.Size(81, 23);
            this.saqueButton.TabIndex = 5;
            this.saqueButton.Text = "Saque";
            this.saqueButton.UseVisualStyleBackColor = true;
            this.saqueButton.Click += new System.EventHandler(this.saqueButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor";
            // 
            // comboDestinos
            // 
            this.comboDestinos.FormattingEnabled = true;
            this.comboDestinos.Location = new System.Drawing.Point(57, 76);
            this.comboDestinos.Name = "comboDestinos";
            this.comboDestinos.Size = new System.Drawing.Size(121, 21);
            this.comboDestinos.TabIndex = 7;
            // 
            // transferenciaButton
            // 
            this.transferenciaButton.Location = new System.Drawing.Point(342, 71);
            this.transferenciaButton.Name = "transferenciaButton";
            this.transferenciaButton.Size = new System.Drawing.Size(81, 23);
            this.transferenciaButton.TabIndex = 8;
            this.transferenciaButton.Text = "Transferência";
            this.transferenciaButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Saque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.TextBox textAgencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saqueButton;
        private System.Windows.Forms.TextBox textSaque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button depositoButton;
        private System.Windows.Forms.TextBox textDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button transferenciaButton;
        private System.Windows.Forms.ComboBox comboDestinos;
        private System.Windows.Forms.Label label7;
    }
}

