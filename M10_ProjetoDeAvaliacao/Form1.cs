namespace M10_ProjetoDeAvaliacao
{
    public partial class Form1 : Form
    {
        public Loja Loja = new Loja();

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        public Form1(Loja loja)
        {
            //PegaFicheiros(); // nao mexer
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loja.PegaFicheiros(Loja);

            /** usei este codigo testae o guardar e pegar os ficheiros
            
            string dataTexto = "20/10/2022";
            DateTime data = DateTime.ParseExact(dataTexto, "dd/MM/yyyy", null);


            Cliente c = new("was", "wasd", data, 124, "email", "numero", "senha");
            Loja.ListaClientes.Add(c);

            Produto p = new("NomeP", 1.1, 10, "Descrição", "Componestes", "CPU");
            Loja.ListaProdutos.Add(p);

            Compra c2 = new(c, p, 1, data);
            Loja.ListaVendas.Add(c2);

            ReStock r = new ReStock(p, 1, data);
            Loja.ListaReStock.Add(r);

            Loja.GuardarFicheiros();

            MessageBox.Show("w");*/

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Form formLogin = new FormLoginCliente(Loja);
            formLogin.Show();
            this.Hide();
        }

        private void btLoja_Click(object sender, EventArgs e)
        {
            Form formLoja = new FormLoja(Loja);
            formLoja.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loja.GuardarFicheiros();
        }

        void PegaFicheiros()
        {
            Loja.PegaFicheiros(Loja);
        }
    }
}