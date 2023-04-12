namespace M10_ProjetoDeAvaliacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btCliente = new Button();
            btLoja = new Button();
            SuspendLayout();
            // 
            // btCliente
            // 
            btCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCliente.Image = (Image)resources.GetObject("btCliente.Image");
            btCliente.Location = new Point(136, 122);
            btCliente.Name = "btCliente";
            btCliente.Size = new Size(200, 200);
            btCliente.TabIndex = 0;
            btCliente.Text = "Cliente";
            btCliente.TextAlign = ContentAlignment.BottomCenter;
            btCliente.UseVisualStyleBackColor = true;
            btCliente.Click += btCliente_Click;
            // 
            // btLoja
            // 
            btLoja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btLoja.Image = (Image)resources.GetObject("btLoja.Image");
            btLoja.Location = new Point(444, 122);
            btLoja.Name = "btLoja";
            btLoja.Size = new Size(200, 200);
            btLoja.TabIndex = 1;
            btLoja.Text = "Loja";
            btLoja.TextAlign = ContentAlignment.BottomCenter;
            btLoja.UseVisualStyleBackColor = true;
            btLoja.Click += btLoja_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btLoja);
            Controls.Add(btCliente);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btCliente;
        private Button btLoja;
    }
}