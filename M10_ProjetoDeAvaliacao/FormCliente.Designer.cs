namespace M10_ProjetoDeAvaliacao
{
    partial class FormCliente
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
            tabPageFazerCompra = new TabPage();
            nupQuantidade = new NumericUpDown();
            label12 = new Label();
            rTbProduto = new RichTextBox();
            cbProduto = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tabPageListaCompras = new TabPage();
            label13 = new Label();
            dgvListaVendas = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nomeP = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            tabPageConta = new TabPage();
            label11 = new Label();
            btSalvarAlteracoes = new Button();
            tbSenhaC = new TextBox();
            label1 = new Label();
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
            panel1 = new Panel();
            btIrConta = new Button();
            btIrListaCompras = new Button();
            btSair = new Button();
            btIrFazerCompra = new Button();
            label10 = new Label();
            btComprar = new Button();
            tabControl.SuspendLayout();
            tabPageFazerCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).BeginInit();
            tabPageListaCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVendas).BeginInit();
            tabPageConta.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(tabPageFazerCompra);
            tabControl.Controls.Add(tabPageListaCompras);
            tabControl.Controls.Add(tabPageConta);
            tabControl.Location = new Point(159, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(641, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPageFazerCompra
            // 
            tabPageFazerCompra.Controls.Add(btComprar);
            tabPageFazerCompra.Controls.Add(nupQuantidade);
            tabPageFazerCompra.Controls.Add(label12);
            tabPageFazerCompra.Controls.Add(rTbProduto);
            tabPageFazerCompra.Controls.Add(cbProduto);
            tabPageFazerCompra.Controls.Add(label3);
            tabPageFazerCompra.Controls.Add(label2);
            tabPageFazerCompra.Location = new Point(4, 4);
            tabPageFazerCompra.Name = "tabPageFazerCompra";
            tabPageFazerCompra.Padding = new Padding(3);
            tabPageFazerCompra.Size = new Size(633, 422);
            tabPageFazerCompra.TabIndex = 0;
            tabPageFazerCompra.Text = "Fazer Compra";
            tabPageFazerCompra.UseVisualStyleBackColor = true;
            // 
            // nupQuantidade
            // 
            nupQuantidade.Enabled = false;
            nupQuantidade.Location = new Point(94, 241);
            nupQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupQuantidade.Name = "nupQuantidade";
            nupQuantidade.Size = new Size(250, 23);
            nupQuantidade.TabIndex = 5;
            nupQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 243);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 4;
            label12.Text = "Quantidade:";
            // 
            // rTbProduto
            // 
            rTbProduto.Location = new Point(94, 129);
            rTbProduto.Name = "rTbProduto";
            rTbProduto.Size = new Size(250, 96);
            rTbProduto.TabIndex = 3;
            rTbProduto.Text = "";
            // 
            // cbProduto
            // 
            cbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProduto.FormattingEnabled = true;
            cbProduto.Location = new Point(94, 100);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(250, 23);
            cbProduto.TabIndex = 2;
            cbProduto.SelectedIndexChanged += cbProduto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 103);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 43);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 0;
            label2.Text = "Loja";
            // 
            // tabPageListaCompras
            // 
            tabPageListaCompras.Controls.Add(label13);
            tabPageListaCompras.Controls.Add(dgvListaVendas);
            tabPageListaCompras.Location = new Point(4, 4);
            tabPageListaCompras.Name = "tabPageListaCompras";
            tabPageListaCompras.Padding = new Padding(3);
            tabPageListaCompras.Size = new Size(633, 422);
            tabPageListaCompras.TabIndex = 1;
            tabPageListaCompras.Text = "Lista de Compras";
            tabPageListaCompras.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 67);
            label13.Name = "label13";
            label13.Size = new Size(196, 32);
            label13.TabIndex = 4;
            label13.Text = "Lista de Compras";
            // 
            // dgvListaVendas
            // 
            dgvListaVendas.AllowUserToAddRows = false;
            dgvListaVendas.AllowUserToDeleteRows = false;
            dgvListaVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaVendas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, nomeP, quantidade, data });
            dgvListaVendas.Location = new Point(0, 102);
            dgvListaVendas.Name = "dgvListaVendas";
            dgvListaVendas.RowTemplate.Height = 25;
            dgvListaVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaVendas.Size = new Size(633, 320);
            dgvListaVendas.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nome Comprador";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // nomeP
            // 
            nomeP.HeaderText = "Produto";
            nomeP.Name = "nomeP";
            nomeP.Width = 150;
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            // 
            // data
            // 
            data.HeaderText = "Data Compra";
            data.Name = "data";
            data.Width = 125;
            // 
            // tabPageConta
            // 
            tabPageConta.Controls.Add(label11);
            tabPageConta.Controls.Add(btSalvarAlteracoes);
            tabPageConta.Controls.Add(tbSenhaC);
            tabPageConta.Controls.Add(label1);
            tabPageConta.Controls.Add(label9);
            tabPageConta.Controls.Add(tbNumeroC);
            tabPageConta.Controls.Add(tbEmailC);
            tabPageConta.Controls.Add(label8);
            tabPageConta.Controls.Add(label7);
            tabPageConta.Controls.Add(mTbNIF);
            tabPageConta.Controls.Add(label6);
            tabPageConta.Controls.Add(dTPDataNascimento);
            tabPageConta.Controls.Add(tbMoradaC);
            tabPageConta.Controls.Add(label5);
            tabPageConta.Controls.Add(tbNomeC);
            tabPageConta.Controls.Add(label4);
            tabPageConta.Location = new Point(4, 4);
            tabPageConta.Name = "tabPageConta";
            tabPageConta.Padding = new Padding(3);
            tabPageConta.Size = new Size(633, 422);
            tabPageConta.TabIndex = 2;
            tabPageConta.Text = "Conta";
            tabPageConta.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(113, 29);
            label11.Name = "label11";
            label11.Size = new Size(212, 32);
            label11.TabIndex = 31;
            label11.Text = "Criar conta na Loja";
            // 
            // btSalvarAlteracoes
            // 
            btSalvarAlteracoes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSalvarAlteracoes.Location = new Point(279, 339);
            btSalvarAlteracoes.Name = "btSalvarAlteracoes";
            btSalvarAlteracoes.Size = new Size(134, 36);
            btSalvarAlteracoes.TabIndex = 30;
            btSalvarAlteracoes.Text = "Salvar Alterações";
            btSalvarAlteracoes.UseVisualStyleBackColor = true;
            btSalvarAlteracoes.Click += btSalvarAlteracoes_Click;
            // 
            // tbSenhaC
            // 
            tbSenhaC.Location = new Point(113, 310);
            tbSenhaC.Name = "tbSenhaC";
            tbSenhaC.Size = new Size(300, 23);
            tbSenhaC.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 313);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 28;
            label1.Text = "Senha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 275);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 27;
            label9.Text = "Número:";
            // 
            // tbNumeroC
            // 
            tbNumeroC.Location = new Point(113, 272);
            tbNumeroC.Name = "tbNumeroC";
            tbNumeroC.Size = new Size(300, 23);
            tbNumeroC.TabIndex = 26;
            // 
            // tbEmailC
            // 
            tbEmailC.Enabled = false;
            tbEmailC.Location = new Point(113, 234);
            tbEmailC.Name = "tbEmailC";
            tbEmailC.Size = new Size(300, 23);
            tbEmailC.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 237);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 24;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 198);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 23;
            label7.Text = "NIF:";
            // 
            // mTbNIF
            // 
            mTbNIF.Enabled = false;
            mTbNIF.Location = new Point(113, 195);
            mTbNIF.Mask = "000000000";
            mTbNIF.Name = "mTbNIF";
            mTbNIF.Size = new Size(200, 23);
            mTbNIF.TabIndex = 22;
            mTbNIF.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 163);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 21;
            label6.Text = "Data Nascimento:";
            // 
            // dTPDataNascimento
            // 
            dTPDataNascimento.Location = new Point(113, 157);
            dTPDataNascimento.Name = "dTPDataNascimento";
            dTPDataNascimento.Size = new Size(200, 23);
            dTPDataNascimento.TabIndex = 20;
            // 
            // tbMoradaC
            // 
            tbMoradaC.Location = new Point(113, 118);
            tbMoradaC.Name = "tbMoradaC";
            tbMoradaC.Size = new Size(300, 23);
            tbMoradaC.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 121);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 18;
            label5.Text = "Morada:";
            // 
            // tbNomeC
            // 
            tbNomeC.Enabled = false;
            tbNomeC.Location = new Point(113, 77);
            tbNomeC.Name = "tbNomeC";
            tbNomeC.Size = new Size(300, 23);
            tbNomeC.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 80);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 16;
            label4.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btIrConta);
            panel1.Controls.Add(btIrListaCompras);
            panel1.Controls.Add(btSair);
            panel1.Controls.Add(btIrFazerCompra);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 450);
            panel1.TabIndex = 1;
            // 
            // btIrConta
            // 
            btIrConta.Location = new Point(3, 222);
            btIrConta.Name = "btIrConta";
            btIrConta.Size = new Size(154, 64);
            btIrConta.TabIndex = 7;
            btIrConta.Text = "Conta";
            btIrConta.UseVisualStyleBackColor = true;
            btIrConta.Click += btIrConta_Click;
            // 
            // btIrListaCompras
            // 
            btIrListaCompras.Location = new Point(3, 152);
            btIrListaCompras.Name = "btIrListaCompras";
            btIrListaCompras.Size = new Size(154, 64);
            btIrListaCompras.TabIndex = 6;
            btIrListaCompras.Text = "Lista de Compras";
            btIrListaCompras.UseVisualStyleBackColor = true;
            btIrListaCompras.Click += btIrListaCompras_Click;
            // 
            // btSair
            // 
            btSair.Location = new Point(3, 387);
            btSair.Name = "btSair";
            btSair.Size = new Size(154, 63);
            btSair.TabIndex = 5;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            // 
            // btIrFazerCompra
            // 
            btIrFazerCompra.Location = new Point(3, 82);
            btIrFazerCompra.Name = "btIrFazerCompra";
            btIrFazerCompra.Size = new Size(154, 64);
            btIrFazerCompra.TabIndex = 1;
            btIrFazerCompra.Text = "Fazer Compra";
            btIrFazerCompra.UseVisualStyleBackColor = true;
            btIrFazerCompra.Click += btIrFazerCompra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 19);
            label10.Name = "label10";
            label10.Size = new Size(135, 50);
            label10.TabIndex = 0;
            label10.Text = "Cliente";
            // 
            // btComprar
            // 
            btComprar.Location = new Point(269, 282);
            btComprar.Name = "btComprar";
            btComprar.Size = new Size(75, 23);
            btComprar.TabIndex = 6;
            btComprar.Text = "Comprar";
            btComprar.UseVisualStyleBackColor = true;
            btComprar.Click += btComprar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tabControl);
            MaximizeBox = false;
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCliente";
            FormClosed += FormCliente_FormClosed;
            Load += FormCliente_Load;
            tabControl.ResumeLayout(false);
            tabPageFazerCompra.ResumeLayout(false);
            tabPageFazerCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).EndInit();
            tabPageListaCompras.ResumeLayout(false);
            tabPageListaCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVendas).EndInit();
            tabPageConta.ResumeLayout(false);
            tabPageConta.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageFazerCompra;
        private TabPage tabPageListaCompras;
        private TabPage tabPageConta;
        private Panel panel1;
        private Button btSair;
        private Button btIrReStock;
        private Button btIrVendas;
        private Button btIrProdutos;
        private Button btIrFazerCompra;
        private Label label10;
        private Label label11;
        private Button btSalvarAlteracoes;
        private TextBox tbSenhaC;
        private Label label1;
        private Label label9;
        private TextBox tbNumeroC;
        private TextBox tbEmailC;
        private Label label8;
        private Label label7;
        private MaskedTextBox mTbNIF;
        private Label label6;
        private DateTimePicker dTPDataNascimento;
        private TextBox tbMoradaC;
        private Label label5;
        private TextBox tbNomeC;
        private Label label4;
        private Label label13;
        private DataGridView dgvListaVendas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nomeP;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn data;
        private Button btIrConta;
        private Button btIrListaCompras;
        private ComboBox cbProduto;
        private Label label3;
        private Label label2;
        private RichTextBox rTbProduto;
        private NumericUpDown nupQuantidade;
        private Label label12;
        private Button btComprar;
    }
}