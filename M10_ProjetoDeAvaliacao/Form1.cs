namespace M10_ProjetoDeAvaliacao
{
    public partial class Form1 : Form
    {
        Loja Loja = new Loja();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loja.PegaFicheiros();

        }

        private void btCliente_Click(object sender, EventArgs e)
        {

        }

        private void btLoja_Click(object sender, EventArgs e)
        {
            Form formLoja = new FormLoja();
            formLoja.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loja.GuardarFicheiros();
            this.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loja.GuardarFicheiros();
            this.Dispose();
        }
    }
}