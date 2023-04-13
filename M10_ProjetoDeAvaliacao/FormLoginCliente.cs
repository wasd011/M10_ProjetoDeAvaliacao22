using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_ProjetoDeAvaliacao
{
    public partial class FormLoginCliente : Form
    {
        Loja Loja = new Loja();

        public FormLoginCliente(Loja Loja)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void FormLoginCliente_Load(object sender, EventArgs e)
        {
            Loja.PegaFicheiros(Loja);

            lbNaoTemConta.Text = "Não tem conta? Clique aqui!";
            lbNaoTemConta.Font = new Font(lbNaoTemConta.Font, FontStyle.Underline);
            lbNaoTemConta.ForeColor = Color.Blue;

            lbJaTemConta.Text = "Não tem conta? Clique aqui!";
            lbJaTemConta.Font = new Font(lbNaoTemConta.Font, FontStyle.Underline);
            lbJaTemConta.ForeColor = Color.Blue;

            dTPDataNascimento.MaxDate = DateTime.Now;

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (Loja.ListaClientes.Count > 0)
            {
                if (Loja.VerificaCliente.VerificaLogin(Loja, tbEmail.Text, tbSenha.Text) != null)
                {
                    Loja.ClienteAtual = Loja.VerificaCliente.VerificaLogin(Loja, tbEmail.Text, tbSenha.Text);

                    Loja.GuardarFicheiros();
                    Form formCliente = new FormCliente(Loja.ClienteAtual);
                    formCliente.Show();
                    this.Dispose();
                    return;

                }
                else
                {
                    MessageBox.Show("Informações de Login Incorretas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparLogin();
                    return;
                }
            }
            LimparLogin();
            MessageBox.Show("Lista de Clientes nula!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btCriarConta_Click(object sender, EventArgs e)
        {
            if (Loja.VerificaCliente.VerificaTudo(Loja, tbNomeC.Text, tbMoradaC.Text,
                    mTbNIF.Text, tbEmailC.Text, tbNumeroC.Text, tbSenhaC.Text))
            {
                Cliente novoCliente = new Cliente();

                novoCliente.nome = tbNomeC.Text;
                novoCliente.morada = tbMoradaC.Text;
                novoCliente.dataNascimento = dTPDataNascimento.Value.Date;
                novoCliente.nif = Convert.ToInt32(mTbNIF.Text);
                novoCliente.email = tbEmailC.Text;
                novoCliente.numero = tbNumeroC.Text;
                novoCliente.senha = tbSenhaC.Text;

                Loja.ListaClientes.Add(novoCliente);
                Loja.ClienteAtual = novoCliente;

                Loja.GuardarFicheiros();
                Form formCliente = new FormCliente(Loja.ClienteAtual);
                formCliente.Show();
                this.Dispose();
            }
        }

        private void ckBMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBMostrarSenha.Checked)
                tbSenha.PasswordChar = '\0';
            else
                tbSenha.PasswordChar = '*';
        }
        void LimparLogin()
        {
            tbEmail.Text = string.Empty;
            tbSenha.Text = string.Empty;
            ckBMostrarSenha.Checked = false;
        }
        void LimparCriarConta()
        {
            tbNomeC.Text = string.Empty;
            tbMoradaC.Text = string.Empty;
            dTPDataNascimento.Value = dTPDataNascimento.MaxDate;
            mTbNIF.Text = string.Empty;
            tbEmailC.Text = string.Empty;
            tbNumeroC.Text = string.Empty;
            tbSenhaC.Text = string.Empty;
        }
        private void lbNaoTemConta_Click(object sender, EventArgs e)
        {
            LimparLogin();
            tabControl.SelectedTab = tabPageCriarConta;
        }
        private void lbJaTemConta_Click(object sender, EventArgs e)
        {
            LimparCriarConta();
            tabControl.SelectedTab = tabPageLogin;
        }

        private void FormLoginCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // nao é preciso
        }
    }
}
