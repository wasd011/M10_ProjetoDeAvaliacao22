namespace M10_ProjetoDeAvaliacao
{
    partial class FormLoginCliente
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
            tabControl = new TabControl();
            tabPageLogin = new TabPage();
            btLogin = new Button();
            lbNaoTemConta = new Label();
            ckBMostrarSenha = new CheckBox();
            tbSenha = new TextBox();
            label2 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            tabPageCriarConta = new TabPage();
            lbJaTemConta = new Label();
            label11 = new Label();
            btCriarConta = new Button();
            tbSenhaC = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tbNumeroC = new TextBox();
            tbEmailC = new TextBox();
            label8 = new Label();
            label7 = new Label();
            mTbNIF = new MaskedTextBox();
            label6 = new Label();
            dTPDataNascimento = new DateTimePicker();
            tbMoradaC = new TextBox();
            label5 = new Label();
            tbNomeC = new TextBox();
            label4 = new Label();
            tabControl.SuspendLayout();
            tabPageLogin.SuspendLayout();
            tabPageCriarConta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(tabPageLogin);
            tabControl.Controls.Add(tabPageCriarConta);
            tabControl.Location = new Point(-7, -2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(813, 479);
            tabControl.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            tabPageLogin.Controls.Add(btLogin);
            tabPageLogin.Controls.Add(lbNaoTemConta);
            tabPageLogin.Controls.Add(ckBMostrarSenha);
            tabPageLogin.Controls.Add(tbSenha);
            tabPageLogin.Controls.Add(label2);
            tabPageLogin.Controls.Add(tbEmail);
            tabPageLogin.Controls.Add(label1);
            tabPageLogin.Location = new Point(4, 4);
            tabPageLogin.Name = "tabPageLogin";
            tabPageLogin.Padding = new Padding(3);
            tabPageLogin.Size = new Size(805, 451);
            tabPageLogin.TabIndex = 0;
            tabPageLogin.Text = "Login";
            tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(339, 207);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(75, 23);
            btLogin.TabIndex = 5;
            btLogin.Text = "Fazer Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lbNaoTemConta
            // 
            lbNaoTemConta.AutoSize = true;
            lbNaoTemConta.ForeColor = Color.Blue;
            lbNaoTemConta.Location = new Point(64, 261);
            lbNaoTemConta.Name = "lbNaoTemConta";
            lbNaoTemConta.Size = new Size(173, 15);
            lbNaoTemConta.TabIndex = 4;
            lbNaoTemConta.Text = "Não tem conta? >Clique aqui!<\r\n";
            lbNaoTemConta.Click += lbNaoTemConta_Click;
            // 
            // ckBMostrarSenha
            // 
            ckBMostrarSenha.AutoSize = true;
            ckBMostrarSenha.Location = new Point(420, 160);
            ckBMostrarSenha.Name = "ckBMostrarSenha";
            ckBMostrarSenha.Size = new Size(102, 19);
            ckBMostrarSenha.TabIndex = 1;
            ckBMostrarSenha.Text = "Mostrar Senha";
            ckBMostrarSenha.UseVisualStyleBackColor = true;
            ckBMostrarSenha.CheckedChanged += ckBMostrarSenha_CheckedChanged;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(114, 156);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(300, 23);
            tbSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 159);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(114, 105);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(300, 23);
            tbEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 108);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail:";
            // 
            // tabPageCriarConta
            // 
            tabPageCriarConta.Controls.Add(lbJaTemConta);
            tabPageCriarConta.Controls.Add(label11);
            tabPageCriarConta.Controls.Add(btCriarConta);
            tabPageCriarConta.Controls.Add(tbSenhaC);
            tabPageCriarConta.Controls.Add(label10);
            tabPageCriarConta.Controls.Add(label9);
            tabPageCriarConta.Controls.Add(tbNumeroC);
            tabPageCriarConta.Controls.Add(tbEmailC);
            tabPageCriarConta.Controls.Add(label8);
            tabPageCriarConta.Controls.Add(label7);
            tabPageCriarConta.Controls.Add(mTbNIF);
            tabPageCriarConta.Controls.Add(label6);
            tabPageCriarConta.Controls.Add(dTPDataNascimento);
            tabPageCriarConta.Controls.Add(tbMoradaC);
            tabPageCriarConta.Controls.Add(label5);
            tabPageCriarConta.Controls.Add(tbNomeC);
            tabPageCriarConta.Controls.Add(label4);
            tabPageCriarConta.Location = new Point(4, 4);
            tabPageCriarConta.Name = "tabPageCriarConta";
            tabPageCriarConta.Padding = new Padding(3);
            tabPageCriarConta.Size = new Size(805, 451);
            tabPageCriarConta.TabIndex = 1;
            tabPageCriarConta.Text = "Criar Conta";
            tabPageCriarConta.UseVisualStyleBackColor = true;
            // 
            // lbJaTemConta
            // 
            lbJaTemConta.AutoSize = true;
            lbJaTemConta.ForeColor = Color.Blue;
            lbJaTemConta.Location = new Point(112, 383);
            lbJaTemConta.Name = "lbJaTemConta";
            lbJaTemConta.Size = new Size(161, 15);
            lbJaTemConta.TabIndex = 16;
            lbJaTemConta.Text = "Já tem conta? >Clique aqui!<\r\n";
            lbJaTemConta.Click += lbJaTemConta_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(112, 31);
            label11.Name = "label11";
            label11.Size = new Size(212, 32);
            label11.TabIndex = 15;
            label11.Text = "Criar conta na Loja";
            // 
            // btCriarConta
            // 
            btCriarConta.Location = new Point(337, 341);
            btCriarConta.Name = "btCriarConta";
            btCriarConta.Size = new Size(75, 23);
            btCriarConta.TabIndex = 14;
            btCriarConta.Text = "Criar Conta";
            btCriarConta.UseVisualStyleBackColor = true;
            btCriarConta.Click += btCriarConta_Click;
            // 
            // tbSenhaC
            // 
            tbSenhaC.Location = new Point(112, 312);
            tbSenhaC.Name = "tbSenhaC";
            tbSenhaC.Size = new Size(300, 23);
            tbSenhaC.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 315);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 12;
            label10.Text = "Senha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 277);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 11;
            label9.Text = "Número:";
            // 
            // tbNumeroC
            // 
            tbNumeroC.Location = new Point(112, 274);
            tbNumeroC.Name = "tbNumeroC";
            tbNumeroC.Size = new Size(300, 23);
            tbNumeroC.TabIndex = 10;
            // 
            // tbEmailC
            // 
            tbEmailC.Location = new Point(112, 236);
            tbEmailC.Name = "tbEmailC";
            tbEmailC.Size = new Size(300, 23);
            tbEmailC.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 239);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 8;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 200);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 7;
            label7.Text = "NIF:";
            // 
            // mTbNIF
            // 
            mTbNIF.Location = new Point(112, 197);
            mTbNIF.Mask = "000000000";
            mTbNIF.Name = "mTbNIF";
            mTbNIF.Size = new Size(200, 23);
            mTbNIF.TabIndex = 6;
            mTbNIF.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 165);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "Data Nascimento:";
            // 
            // dTPDataNascimento
            // 
            dTPDataNascimento.Location = new Point(112, 159);
            dTPDataNascimento.Name = "dTPDataNascimento";
            dTPDataNascimento.Size = new Size(200, 23);
            dTPDataNascimento.TabIndex = 4;
            // 
            // tbMoradaC
            // 
            tbMoradaC.Location = new Point(112, 120);
            tbMoradaC.Name = "tbMoradaC";
            tbMoradaC.Size = new Size(300, 23);
            tbMoradaC.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 123);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 2;
            label5.Text = "Morada:";
            // 
            // tbNomeC
            // 
            tbNomeC.Location = new Point(112, 79);
            tbNomeC.Name = "tbNomeC";
            tbNomeC.Size = new Size(300, 23);
            tbNomeC.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 82);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome:";
            // 
            // FormLoginCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(tabControl);
            MaximizeBox = false;
            Name = "FormLoginCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área Login Cliente";
            FormClosed += FormLoginCliente_FormClosed;
            Load += FormLoginCliente_Load;
            tabControl.ResumeLayout(false);
            tabPageLogin.ResumeLayout(false);
            tabPageLogin.PerformLayout();
            tabPageCriarConta.ResumeLayout(false);
            tabPageCriarConta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageLogin;
        private TabPage tabPageCriarConta;
        private Label lbNaoTemConta;
        private CheckBox ckBMostrarSenha;
        private TextBox tbSenha;
        private Label label2;
        private TextBox tbEmail;
        private Label label1;
        private Button btLogin;
        private TextBox tbNomeC;
        private Label label4;
        private TextBox tbMoradaC;
        private Label label5;
        private DateTimePicker dTPDataNascimento;
        private Label label6;
        private Label label7;
        private MaskedTextBox mTbNIF;
        private Label label8;
        private TextBox tbSenhaC;
        private Label label10;
        private Label label9;
        private TextBox tbNumeroC;
        private TextBox tbEmailC;
        private Label label11;
        private Button btCriarConta;
        private Label lbJaTemConta;
    }
}