namespace M10_ProjetoDeAvaliacao
{
    partial class FormLoja
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btSair = new Button();
            btIrReStock = new Button();
            btIrVendas = new Button();
            btIrProdutos = new Button();
            btIrClientes = new Button();
            label10 = new Label();
            tabPrincipal = new TabControl();
            tabPageCliente = new TabPage();
            tabControlCliente = new TabControl();
            tabPageListaClientes = new TabPage();
            label11 = new Label();
            dgvListaClientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            morada = new DataGridViewTextBoxColumn();
            DataNas = new DataGridViewTextBoxColumn();
            nif = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            tabPageProduto = new TabPage();
            tabControlProduto = new TabControl();
            tabPageListaProdutos = new TabPage();
            label12 = new Label();
            dgvListaProdutos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            disponivel = new DataGridViewTextBoxColumn();
            cMSProduto = new ContextMenuStrip(components);
            editarProdutoToolStripMenuItem = new ToolStripMenuItem();
            tabPageAddProduto = new TabPage();
            btAlterarProduto = new Button();
            label6 = new Label();
            btAddProduto = new Button();
            tbCategoriaP = new TextBox();
            label5 = new Label();
            rTbDescricao = new RichTextBox();
            label4 = new Label();
            nupStockP = new NumericUpDown();
            label3 = new Label();
            nupPrecoP = new NumericUpDown();
            label2 = new Label();
            tbNomeP = new TextBox();
            label1 = new Label();
            tabPageVenda = new TabPage();
            tabControlVendas = new TabControl();
            tabPageListaVendas = new TabPage();
            label13 = new Label();
            dgvListaVendas = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nomeP = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            tabPageReStock = new TabPage();
            tabControlReStock = new TabControl();
            tabPageListaReStock = new TabPage();
            label14 = new Label();
            dgvListaReStock = new DataGridView();
            produto = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tabPageAddReStock = new TabPage();
            label9 = new Label();
            btAddReStock = new Button();
            label8 = new Label();
            nupQuantidadeReStock = new NumericUpDown();
            cbProdutoReStock = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            tabPrincipal.SuspendLayout();
            tabPageCliente.SuspendLayout();
            tabControlCliente.SuspendLayout();
            tabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            tabPageProduto.SuspendLayout();
            tabControlProduto.SuspendLayout();
            tabPageListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).BeginInit();
            cMSProduto.SuspendLayout();
            tabPageAddProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupStockP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecoP).BeginInit();
            tabPageVenda.SuspendLayout();
            tabControlVendas.SuspendLayout();
            tabPageListaVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVendas).BeginInit();
            tabPageReStock.SuspendLayout();
            tabControlReStock.SuspendLayout();
            tabPageListaReStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaReStock).BeginInit();
            tabPageAddReStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantidadeReStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btSair);
            panel1.Controls.Add(btIrReStock);
            panel1.Controls.Add(btIrVendas);
            panel1.Controls.Add(btIrProdutos);
            panel1.Controls.Add(btIrClientes);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 450);
            panel1.TabIndex = 0;
            // 
            // btSair
            // 
            btSair.Location = new Point(3, 387);
            btSair.Name = "btSair";
            btSair.Size = new Size(154, 63);
            btSair.TabIndex = 5;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // btIrReStock
            // 
            btIrReStock.Location = new Point(3, 292);
            btIrReStock.Name = "btIrReStock";
            btIrReStock.Size = new Size(154, 63);
            btIrReStock.TabIndex = 4;
            btIrReStock.Text = "ReStock";
            btIrReStock.UseVisualStyleBackColor = true;
            btIrReStock.Click += btIrReStock_Click;
            // 
            // btIrVendas
            // 
            btIrVendas.Location = new Point(3, 222);
            btIrVendas.Name = "btIrVendas";
            btIrVendas.Size = new Size(154, 64);
            btIrVendas.TabIndex = 3;
            btIrVendas.Text = "Vendas";
            btIrVendas.UseVisualStyleBackColor = true;
            btIrVendas.Click += btIrVendas_Click;
            // 
            // btIrProdutos
            // 
            btIrProdutos.Location = new Point(3, 152);
            btIrProdutos.Name = "btIrProdutos";
            btIrProdutos.Size = new Size(154, 64);
            btIrProdutos.TabIndex = 2;
            btIrProdutos.Text = "Produtos";
            btIrProdutos.UseVisualStyleBackColor = true;
            btIrProdutos.Click += btIrProdutos_Click;
            // 
            // btIrClientes
            // 
            btIrClientes.Location = new Point(3, 82);
            btIrClientes.Name = "btIrClientes";
            btIrClientes.Size = new Size(154, 64);
            btIrClientes.TabIndex = 1;
            btIrClientes.Text = "Clientes";
            btIrClientes.UseVisualStyleBackColor = true;
            btIrClientes.Click += btIrClientes_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(34, 18);
            label10.Name = "label10";
            label10.Size = new Size(89, 50);
            label10.TabIndex = 0;
            label10.Text = "Loja";
            // 
            // tabPrincipal
            // 
            tabPrincipal.Alignment = TabAlignment.Bottom;
            tabPrincipal.Controls.Add(tabPageCliente);
            tabPrincipal.Controls.Add(tabPageProduto);
            tabPrincipal.Controls.Add(tabPageVenda);
            tabPrincipal.Controls.Add(tabPageReStock);
            tabPrincipal.Dock = DockStyle.Right;
            tabPrincipal.Location = new Point(159, 0);
            tabPrincipal.Margin = new Padding(3, 2, 3, 2);
            tabPrincipal.Multiline = true;
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(641, 450);
            tabPrincipal.TabIndex = 1;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Controls.Add(tabControlCliente);
            tabPageCliente.Location = new Point(4, 4);
            tabPageCliente.Margin = new Padding(3, 2, 3, 2);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3, 2, 3, 2);
            tabPageCliente.Size = new Size(633, 422);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Clientes";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // tabControlCliente
            // 
            tabControlCliente.Alignment = TabAlignment.Bottom;
            tabControlCliente.Controls.Add(tabPageListaClientes);
            tabControlCliente.Location = new Point(-4, -4);
            tabControlCliente.Name = "tabControlCliente";
            tabControlCliente.SelectedIndex = 0;
            tabControlCliente.Size = new Size(641, 426);
            tabControlCliente.TabIndex = 0;
            // 
            // tabPageListaClientes
            // 
            tabPageListaClientes.Controls.Add(label11);
            tabPageListaClientes.Controls.Add(dgvListaClientes);
            tabPageListaClientes.Location = new Point(4, 4);
            tabPageListaClientes.Name = "tabPageListaClientes";
            tabPageListaClientes.Padding = new Padding(3);
            tabPageListaClientes.Size = new Size(633, 398);
            tabPageListaClientes.TabIndex = 0;
            tabPageListaClientes.Text = "Lista Clientes";
            tabPageListaClientes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 43);
            label11.Name = "label11";
            label11.Size = new Size(153, 32);
            label11.TabIndex = 1;
            label11.Text = "Lista Clientes";
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.AllowUserToAddRows = false;
            dgvListaClientes.AllowUserToDeleteRows = false;
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Columns.AddRange(new DataGridViewColumn[] { nome, morada, DataNas, nif, email, numero });
            dgvListaClientes.Location = new Point(0, 78);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.ReadOnly = true;
            dgvListaClientes.RowTemplate.Height = 25;
            dgvListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaClientes.Size = new Size(635, 320);
            dgvListaClientes.TabIndex = 0;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // morada
            // 
            morada.HeaderText = "Morada";
            morada.Name = "morada";
            morada.ReadOnly = true;
            // 
            // DataNas
            // 
            DataNas.HeaderText = "DataNasc";
            DataNas.Name = "DataNas";
            DataNas.ReadOnly = true;
            // 
            // nif
            // 
            nif.HeaderText = "NIF";
            nif.Name = "nif";
            nif.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // numero
            // 
            numero.HeaderText = "Número";
            numero.Name = "numero";
            numero.ReadOnly = true;
            // 
            // tabPageProduto
            // 
            tabPageProduto.Controls.Add(tabControlProduto);
            tabPageProduto.Location = new Point(4, 4);
            tabPageProduto.Margin = new Padding(3, 2, 3, 2);
            tabPageProduto.Name = "tabPageProduto";
            tabPageProduto.Padding = new Padding(3, 2, 3, 2);
            tabPageProduto.Size = new Size(633, 422);
            tabPageProduto.TabIndex = 1;
            tabPageProduto.Text = "Produtos";
            tabPageProduto.UseVisualStyleBackColor = true;
            // 
            // tabControlProduto
            // 
            tabControlProduto.Alignment = TabAlignment.Bottom;
            tabControlProduto.Controls.Add(tabPageListaProdutos);
            tabControlProduto.Controls.Add(tabPageAddProduto);
            tabControlProduto.Location = new Point(-4, -4);
            tabControlProduto.Name = "tabControlProduto";
            tabControlProduto.SelectedIndex = 0;
            tabControlProduto.Size = new Size(641, 426);
            tabControlProduto.TabIndex = 0;
            // 
            // tabPageListaProdutos
            // 
            tabPageListaProdutos.Controls.Add(label12);
            tabPageListaProdutos.Controls.Add(dgvListaProdutos);
            tabPageListaProdutos.Location = new Point(4, 4);
            tabPageListaProdutos.Name = "tabPageListaProdutos";
            tabPageListaProdutos.Padding = new Padding(3);
            tabPageListaProdutos.Size = new Size(633, 398);
            tabPageListaProdutos.TabIndex = 0;
            tabPageListaProdutos.Text = "Lista Produtos";
            tabPageListaProdutos.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 43);
            label12.Name = "label12";
            label12.Size = new Size(163, 32);
            label12.TabIndex = 2;
            label12.Text = "Lista Produtos";
            // 
            // dgvListaProdutos
            // 
            dgvListaProdutos.AllowUserToAddRows = false;
            dgvListaProdutos.AllowUserToDeleteRows = false;
            dgvListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProdutos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, preco, stock, descricao, categoria, disponivel });
            dgvListaProdutos.ContextMenuStrip = cMSProduto;
            dgvListaProdutos.Location = new Point(0, 78);
            dgvListaProdutos.Name = "dgvListaProdutos";
            dgvListaProdutos.RowTemplate.Height = 25;
            dgvListaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProdutos.Size = new Size(630, 320);
            dgvListaProdutos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // preco
            // 
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            // 
            // disponivel
            // 
            disponivel.HeaderText = "Disponível";
            disponivel.Name = "disponivel";
            // 
            // cMSProduto
            // 
            cMSProduto.Items.AddRange(new ToolStripItem[] { editarProdutoToolStripMenuItem });
            cMSProduto.Name = "cMSProduto";
            cMSProduto.Size = new Size(105, 26);
            // 
            // editarProdutoToolStripMenuItem
            // 
            editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            editarProdutoToolStripMenuItem.Size = new Size(104, 22);
            editarProdutoToolStripMenuItem.Text = "Editar";
            editarProdutoToolStripMenuItem.Click += editarProdutoToolStripMenuItem_Click;
            // 
            // tabPageAddProduto
            // 
            tabPageAddProduto.Controls.Add(btAlterarProduto);
            tabPageAddProduto.Controls.Add(label6);
            tabPageAddProduto.Controls.Add(btAddProduto);
            tabPageAddProduto.Controls.Add(tbCategoriaP);
            tabPageAddProduto.Controls.Add(label5);
            tabPageAddProduto.Controls.Add(rTbDescricao);
            tabPageAddProduto.Controls.Add(label4);
            tabPageAddProduto.Controls.Add(nupStockP);
            tabPageAddProduto.Controls.Add(label3);
            tabPageAddProduto.Controls.Add(nupPrecoP);
            tabPageAddProduto.Controls.Add(label2);
            tabPageAddProduto.Controls.Add(tbNomeP);
            tabPageAddProduto.Controls.Add(label1);
            tabPageAddProduto.Location = new Point(4, 4);
            tabPageAddProduto.Name = "tabPageAddProduto";
            tabPageAddProduto.Padding = new Padding(3);
            tabPageAddProduto.Size = new Size(633, 398);
            tabPageAddProduto.TabIndex = 1;
            tabPageAddProduto.Text = "Adicionar Produto";
            tabPageAddProduto.UseVisualStyleBackColor = true;
            // 
            // btAlterarProduto
            // 
            btAlterarProduto.Enabled = false;
            btAlterarProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterarProduto.Location = new Point(29, 330);
            btAlterarProduto.Name = "btAlterarProduto";
            btAlterarProduto.Size = new Size(100, 39);
            btAlterarProduto.TabIndex = 12;
            btAlterarProduto.Text = "Alterar";
            btAlterarProduto.UseVisualStyleBackColor = true;
            btAlterarProduto.Click += btAlterarProduto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 14);
            label6.Name = "label6";
            label6.Size = new Size(206, 32);
            label6.TabIndex = 11;
            label6.Text = "Adicionar Produto";
            // 
            // btAddProduto
            // 
            btAddProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btAddProduto.Location = new Point(247, 330);
            btAddProduto.Name = "btAddProduto";
            btAddProduto.Size = new Size(100, 39);
            btAddProduto.TabIndex = 10;
            btAddProduto.Text = "Adicionar";
            btAddProduto.UseVisualStyleBackColor = true;
            btAddProduto.Click += btAddProduto_Click;
            // 
            // tbCategoriaP
            // 
            tbCategoriaP.Location = new Point(78, 288);
            tbCategoriaP.Name = "tbCategoriaP";
            tbCategoriaP.Size = new Size(269, 23);
            tbCategoriaP.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 291);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Categoria:";
            // 
            // rTbDescricao
            // 
            rTbDescricao.Location = new Point(78, 189);
            rTbDescricao.Name = "rTbDescricao";
            rTbDescricao.Size = new Size(269, 83);
            rTbDescricao.TabIndex = 7;
            rTbDescricao.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 192);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Descrição:";
            // 
            // nupStockP
            // 
            nupStockP.Location = new Point(78, 147);
            nupStockP.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nupStockP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupStockP.Name = "nupStockP";
            nupStockP.Size = new Size(269, 23);
            nupStockP.TabIndex = 5;
            nupStockP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 149);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Stock";
            // 
            // nupPrecoP
            // 
            nupPrecoP.DecimalPlaces = 2;
            nupPrecoP.Location = new Point(78, 104);
            nupPrecoP.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nupPrecoP.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nupPrecoP.Name = "nupPrecoP";
            nupPrecoP.Size = new Size(269, 23);
            nupPrecoP.TabIndex = 3;
            nupPrecoP.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço:";
            // 
            // tbNomeP
            // 
            tbNomeP.Location = new Point(78, 62);
            tbNomeP.Name = "tbNomeP";
            tbNomeP.Size = new Size(269, 23);
            tbNomeP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 65);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tabPageVenda
            // 
            tabPageVenda.Controls.Add(tabControlVendas);
            tabPageVenda.Location = new Point(4, 4);
            tabPageVenda.Name = "tabPageVenda";
            tabPageVenda.Padding = new Padding(3);
            tabPageVenda.Size = new Size(633, 422);
            tabPageVenda.TabIndex = 2;
            tabPageVenda.Text = "Vendas";
            tabPageVenda.UseVisualStyleBackColor = true;
            // 
            // tabControlVendas
            // 
            tabControlVendas.Alignment = TabAlignment.Bottom;
            tabControlVendas.Controls.Add(tabPageListaVendas);
            tabControlVendas.Location = new Point(-4, -4);
            tabControlVendas.Multiline = true;
            tabControlVendas.Name = "tabControlVendas";
            tabControlVendas.SelectedIndex = 0;
            tabControlVendas.Size = new Size(641, 426);
            tabControlVendas.TabIndex = 0;
            // 
            // tabPageListaVendas
            // 
            tabPageListaVendas.Controls.Add(label13);
            tabPageListaVendas.Controls.Add(dgvListaVendas);
            tabPageListaVendas.Location = new Point(4, 4);
            tabPageListaVendas.Name = "tabPageListaVendas";
            tabPageListaVendas.Padding = new Padding(3);
            tabPageListaVendas.Size = new Size(633, 398);
            tabPageListaVendas.TabIndex = 0;
            tabPageListaVendas.Text = "Lista de Vendas";
            tabPageListaVendas.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 44);
            label13.Name = "label13";
            label13.Size = new Size(178, 32);
            label13.TabIndex = 2;
            label13.Text = "Lista de Vendas";
            // 
            // dgvListaVendas
            // 
            dgvListaVendas.AllowUserToAddRows = false;
            dgvListaVendas.AllowUserToDeleteRows = false;
            dgvListaVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaVendas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, nomeP, quantidade, data });
            dgvListaVendas.Location = new Point(0, 79);
            dgvListaVendas.Name = "dgvListaVendas";
            dgvListaVendas.RowTemplate.Height = 25;
            dgvListaVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaVendas.Size = new Size(633, 320);
            dgvListaVendas.TabIndex = 0;
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
            // tabPageReStock
            // 
            tabPageReStock.Controls.Add(tabControlReStock);
            tabPageReStock.Location = new Point(4, 4);
            tabPageReStock.Name = "tabPageReStock";
            tabPageReStock.Padding = new Padding(3);
            tabPageReStock.Size = new Size(633, 422);
            tabPageReStock.TabIndex = 3;
            tabPageReStock.Text = "ReStock";
            tabPageReStock.UseVisualStyleBackColor = true;
            // 
            // tabControlReStock
            // 
            tabControlReStock.Alignment = TabAlignment.Bottom;
            tabControlReStock.Controls.Add(tabPageListaReStock);
            tabControlReStock.Controls.Add(tabPageAddReStock);
            tabControlReStock.Location = new Point(-4, -4);
            tabControlReStock.Name = "tabControlReStock";
            tabControlReStock.SelectedIndex = 0;
            tabControlReStock.Size = new Size(641, 426);
            tabControlReStock.TabIndex = 0;
            // 
            // tabPageListaReStock
            // 
            tabPageListaReStock.Controls.Add(label14);
            tabPageListaReStock.Controls.Add(dgvListaReStock);
            tabPageListaReStock.Location = new Point(4, 4);
            tabPageListaReStock.Name = "tabPageListaReStock";
            tabPageListaReStock.Padding = new Padding(3);
            tabPageListaReStock.Size = new Size(633, 398);
            tabPageListaReStock.TabIndex = 1;
            tabPageListaReStock.Text = "Lista de ReStock";
            tabPageListaReStock.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 43);
            label14.Name = "label14";
            label14.Size = new Size(151, 32);
            label14.TabIndex = 2;
            label14.Text = "Lista ReStock";
            // 
            // dgvListaReStock
            // 
            dgvListaReStock.AllowUserToAddRows = false;
            dgvListaReStock.AllowUserToDeleteRows = false;
            dgvListaReStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaReStock.Columns.AddRange(new DataGridViewColumn[] { produto, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn3 });
            dgvListaReStock.Location = new Point(0, 78);
            dgvListaReStock.Name = "dgvListaReStock";
            dgvListaReStock.RowTemplate.Height = 25;
            dgvListaReStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaReStock.Size = new Size(633, 320);
            dgvListaReStock.TabIndex = 0;
            // 
            // produto
            // 
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Data";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // tabPageAddReStock
            // 
            tabPageAddReStock.Controls.Add(label9);
            tabPageAddReStock.Controls.Add(btAddReStock);
            tabPageAddReStock.Controls.Add(label8);
            tabPageAddReStock.Controls.Add(nupQuantidadeReStock);
            tabPageAddReStock.Controls.Add(cbProdutoReStock);
            tabPageAddReStock.Controls.Add(label7);
            tabPageAddReStock.Location = new Point(4, 4);
            tabPageAddReStock.Name = "tabPageAddReStock";
            tabPageAddReStock.Padding = new Padding(3);
            tabPageAddReStock.Size = new Size(633, 398);
            tabPageAddReStock.TabIndex = 0;
            tabPageAddReStock.Text = "Adicionar ReStock";
            tabPageAddReStock.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(29, 49);
            label9.Name = "label9";
            label9.Size = new Size(348, 32);
            label9.TabIndex = 5;
            label9.Text = "Adicionar Stock de Um Produto";
            // 
            // btAddReStock
            // 
            btAddReStock.Location = new Point(391, 194);
            btAddReStock.Name = "btAddReStock";
            btAddReStock.Size = new Size(97, 42);
            btAddReStock.TabIndex = 4;
            btAddReStock.Text = "Adicionar Stock Produto";
            btAddReStock.UseVisualStyleBackColor = true;
            btAddReStock.Click += btAddReStock_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 145);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 3;
            label8.Text = "Quantidade:";
            // 
            // nupQuantidadeReStock
            // 
            nupQuantidadeReStock.Location = new Point(88, 143);
            nupQuantidadeReStock.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nupQuantidadeReStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupQuantidadeReStock.Name = "nupQuantidadeReStock";
            nupQuantidadeReStock.Size = new Size(150, 23);
            nupQuantidadeReStock.TabIndex = 2;
            nupQuantidadeReStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbProdutoReStock
            // 
            cbProdutoReStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProdutoReStock.FormattingEnabled = true;
            cbProdutoReStock.Location = new Point(88, 104);
            cbProdutoReStock.Name = "cbProdutoReStock";
            cbProdutoReStock.Size = new Size(400, 23);
            cbProdutoReStock.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 107);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 0;
            label7.Text = "Produto:";
            // 
            // FormLoja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabPrincipal);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormLoja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área Administrativa da Loja";
            FormClosed += FormLoja_FormClosed;
            Load += FormLoja_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPrincipal.ResumeLayout(false);
            tabPageCliente.ResumeLayout(false);
            tabControlCliente.ResumeLayout(false);
            tabPageListaClientes.ResumeLayout(false);
            tabPageListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            tabPageProduto.ResumeLayout(false);
            tabControlProduto.ResumeLayout(false);
            tabPageListaProdutos.ResumeLayout(false);
            tabPageListaProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).EndInit();
            cMSProduto.ResumeLayout(false);
            tabPageAddProduto.ResumeLayout(false);
            tabPageAddProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupStockP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecoP).EndInit();
            tabPageVenda.ResumeLayout(false);
            tabControlVendas.ResumeLayout(false);
            tabPageListaVendas.ResumeLayout(false);
            tabPageListaVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVendas).EndInit();
            tabPageReStock.ResumeLayout(false);
            tabControlReStock.ResumeLayout(false);
            tabPageListaReStock.ResumeLayout(false);
            tabPageListaReStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaReStock).EndInit();
            tabPageAddReStock.ResumeLayout(false);
            tabPageAddReStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantidadeReStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabPrincipal;
        private TabPage tabPageCliente;
        private TabPage tabPageProduto;
        private TabPage tabPageVenda;
        private TabPage tabPageReStock;
        private TabControl tabControlCliente;
        private TabPage tabPageListaClientes;
        private TabControl tabControlProduto;
        private TabPage tabPageListaProdutos;
        private TabPage tabPageAddProduto;
        private TabControl tabControlVendas;
        private TabPage tabPageListaVendas;
        private TabControl tabControlReStock;
        private TabPage tabPageAddReStock;
        private TabPage tabPageListaReStock;
        private DataGridView dgvListaClientes;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn morada;
        private DataGridViewTextBoxColumn DataNas;
        private DataGridViewTextBoxColumn nif;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn numero;
        private DataGridView dgvListaProdutos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn disponivel;
        private NumericUpDown nupPrecoP;
        private Label label2;
        private TextBox tbNomeP;
        private Label label1;
        private RichTextBox rTbDescricao;
        private Label label4;
        private NumericUpDown nupStockP;
        private Label label3;
        private TextBox tbCategoriaP;
        private Label label5;
        private Label label6;
        private Button btAddProduto;
        private DataGridView dgvListaVendas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nomeP;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn data;
        private DataGridView dgvListaReStock;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label7;
        private ComboBox cbProdutoReStock;
        private Button btAddReStock;
        private Label label8;
        private NumericUpDown nupQuantidadeReStock;
        private Button btAlterarProduto;
        private Label label9;
        private Button btIrReStock;
        private Button btIrVendas;
        private Button btIrProdutos;
        private Button btIrClientes;
        private Label label10;
        private Button btSair;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ContextMenuStrip cMSProduto;
        private ToolStripMenuItem editarProdutoToolStripMenuItem;
    }
}