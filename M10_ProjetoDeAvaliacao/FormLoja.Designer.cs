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
            panel1 = new Panel();
            tabPrincipal = new TabControl();
            tabPageCliente = new TabPage();
            tabPageProduto = new TabPage();
            tabPageReStock = new TabPage();
            tabPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 428);
            panel1.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            tabPrincipal.Alignment = TabAlignment.Bottom;
            tabPrincipal.Controls.Add(tabPageCliente);
            tabPrincipal.Controls.Add(tabPageProduto);
            tabPrincipal.Controls.Add(tabPageReStock);
            tabPrincipal.Location = new Point(200, 11);
            tabPrincipal.Margin = new Padding(3, 2, 3, 2);
            tabPrincipal.Multiline = true;
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(588, 428);
            tabPrincipal.TabIndex = 1;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Location = new Point(4, 4);
            tabPageCliente.Margin = new Padding(3, 2, 3, 2);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3, 2, 3, 2);
            tabPageCliente.Size = new Size(580, 400);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Cliente";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // tabPageProduto
            // 
            tabPageProduto.Location = new Point(4, 4);
            tabPageProduto.Margin = new Padding(3, 2, 3, 2);
            tabPageProduto.Name = "tabPageProduto";
            tabPageProduto.Padding = new Padding(3, 2, 3, 2);
            tabPageProduto.Size = new Size(580, 400);
            tabPageProduto.TabIndex = 1;
            tabPageProduto.Text = "Produto";
            tabPageProduto.UseVisualStyleBackColor = true;
            // 
            // tabPageReStock
            // 
            tabPageReStock.Location = new Point(4, 4);
            tabPageReStock.Margin = new Padding(3, 2, 3, 2);
            tabPageReStock.Name = "tabPageReStock";
            tabPageReStock.Padding = new Padding(3, 2, 3, 2);
            tabPageReStock.Size = new Size(580, 400);
            tabPageReStock.TabIndex = 2;
            tabPageReStock.Text = "ReStock";
            tabPageReStock.UseVisualStyleBackColor = true;
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
            Name = "FormLoja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoja";
            FormClosed += FormLoja_FormClosed;
            Load += FormLoja_Load;
            tabPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabPrincipal;
        private TabPage tabPageCliente;
        private TabPage tabPageProduto;
        private TabPage tabPageReStock;
    }
}