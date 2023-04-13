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
    public partial class FormCliente : Form
    {
        Loja Loja = new Loja();
        int indexDoClienteAtualNaListaDeClientes = -1;
        List<Compra> ListaComprasClienteAtual = new List<Compra>();
        Produto produtoSelecionado = new Produto();

        public FormCliente(Cliente ClienteAtual)
        {
            Loja.ClienteAtual = ClienteAtual;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Loja.PegaFicheiros(Loja);

            for (int i = 0; i < Loja.ListaClientes.Count; i++)
            {
                if (Loja.ListaClientes[0].nif == Loja.ClienteAtual.nif)
                {
                    indexDoClienteAtualNaListaDeClientes = i;
                    break;
                }
            }
            if (indexDoClienteAtualNaListaDeClientes == -1)
            {
                MessageBox.Show("Erro, não pegou index do cliente atual na Lista de Clientes" +
                    "\n" + indexDoClienteAtualNaListaDeClientes.ToString());
            }

            PegaComprasClienteAtual();
            AtualizaDGVComprasClienteAtual();
            AtualizarCBBoxProduto();
            AtualizarConta();


            dTPDataNascimento.MaxDate = DateTime.Now;
        }

        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loja.GuardarFicheiros();
            Loja.ClienteAtual = null;
            Form formInical = new Form1(Loja);
            formInical.Show();
            this.Dispose();
        }
        private void btSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (!MoradaValida())
            {
                MessageBox.Show("Morada inválida" +
                    "\nInformações não guardadas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMoradaC.Text = string.Empty;
                return;
            }
            else if (!NumeroValido())
            {
                MessageBox.Show("Número telefónico inválido!" +
                    "\nInformações não guardadas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumeroC.Text = string.Empty;
                return;
            }
            else if (!SenhaValida())
            {
                MessageBox.Show("Senha inválida!" +
                    "\nInformações não guardadas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenhaC.Text = string.Empty;
                return;
            }
            else
            {
                Loja.ListaClientes[indexDoClienteAtualNaListaDeClientes].morada = tbMoradaC.Text;
                Loja.ListaClientes[indexDoClienteAtualNaListaDeClientes].dataNascimento = dTPDataNascimento.Value.Date;
                Loja.ListaClientes[indexDoClienteAtualNaListaDeClientes].numero = tbNumeroC.Text;
                Loja.ListaClientes[indexDoClienteAtualNaListaDeClientes].senha = tbSenhaC.Text;

                Loja.ClienteAtual = Loja.ListaClientes[indexDoClienteAtualNaListaDeClientes];

                PegaComprasClienteAtual();
                AtualizaDGVComprasClienteAtual();
            }

        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            if (cbProduto.SelectedIndex != -1)
            {
                Compra compra = new Compra();

                compra.produto = produtoSelecionado;
                compra.comprador = Loja.ClienteAtual;
                compra.dataCompra = DateTime.Now.Date;
                compra.quantidade = (int)nupQuantidade.Value;

                TirarStock(compra);

                Loja.ListaVendas.Add(compra);
                PegaComprasClienteAtual();
                AtualizarCBBoxProduto();
                AtualizaDGVComprasClienteAtual();
                LimprCamposCompra();
                Loja.GuardarFicheiros();
            }
        }
        void TirarStock(Compra compra)
        {
            foreach (Produto x in Loja.ListaProdutos)
            {
                if (x.nome == produtoSelecionado.nome)
                    x.Venda(compra.quantidade);
                return;
            }
        }
        void AtualizarConta()
        {
            tbNomeC.Text = Loja.ClienteAtual.nome;
            tbMoradaC.Text = Loja.ClienteAtual.morada;
            dTPDataNascimento.Value = Loja.ClienteAtual.dataNascimento;
            mTbNIF.Text = Loja.ClienteAtual.nif.ToString();
            tbEmailC.Text = Loja.ClienteAtual.email;
            tbNumeroC.Text = Loja.ClienteAtual.numero;
            tbSenhaC.Text = Loja.ClienteAtual.senha;
        }
        void AtualizarCBBoxProduto()
        {
            cbProduto.Items.Clear();

            if (Loja.ListaProdutos.Count > 0 && DevolveNumeroProdutosDisponiveis() > 0)
            {
                foreach (Produto x in Loja.ListaProdutos)
                {
                    if (x.disponivel && x.stock > 0)
                    {
                        cbProduto.Items.Add(x.nome);
                    }
                }
            }
        }
        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduto.SelectedIndex != -1)
            {
                Produto p = new();
                foreach (Produto x in Loja.ListaProdutos)
                {
                    if (x.nome == cbProduto.SelectedItem.ToString())
                    {
                        p = x;
                    }
                }
                rTbProduto.Text = p.nome +
                    "\nPreço: " + p.preco.ToString() + "€" +
                    "\nStock: " + p.stock.ToString() +
                    "\nCategoria: " + p.categoria +
                    "\n\n" + p.descricao;

                nupQuantidade.Maximum = (int)p.stock;
                nupQuantidade.Enabled = true;

                produtoSelecionado = p;
            }
        }
        void LimprCamposCompra()
        {
            cbProduto.SelectedIndex = -1;
            nupQuantidade.Enabled = false;
            nupQuantidade.Value = nupQuantidade.Maximum;
            produtoSelecionado = null;
            rTbProduto.Text = string.Empty;
        }
        int DevolveNumeroProdutosDisponiveis()
        {
            int n = 0;
            foreach (Produto x in Loja.ListaProdutos)
            {
                if (x.disponivel && x.stock > 0)
                    n++;
            }
            return n;
        }
        bool SenhaValida()
        {
            return (!Loja.VerificaCliente.Senha(tbSenhaC.Text) || tbSenhaC.Text.Contains("|"));
        }
        bool NumeroValido()
        {
            return (!Loja.VerificaCliente.Numero(tbNumeroC.Text) || tbNumeroC.Text.Contains("|"));
        }
        bool MoradaValida()
        {
            return (!Loja.VerificaCliente.Morada(tbMoradaC.Text) || tbMoradaC.Text.Contains("|"));

        }
        void AtualizaDGVComprasClienteAtual()
        {
            dgvListaVendas.Rows.Clear();
            if (ListaComprasClienteAtual.Count > 0)
            {
                foreach (Compra x in ListaComprasClienteAtual)
                {
                    dgvListaVendas.Rows.Add(x.comprador.nome, x.produto.nome, x.quantidade, x.dataCompra);
                }
            }
        }
        void PegaComprasClienteAtual()
        {
            ListaComprasClienteAtual.Clear();

            foreach (Compra x in Loja.ListaVendas)
            {
                if (x.comprador.nif == Loja.ListaClientes[indexDoClienteAtualNaListaDeClientes].nif)
                {
                    ListaComprasClienteAtual.Add(x);
                }
            }
        }

        private void btIrFazerCompra_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageFazerCompra;
        }

        private void btIrListaCompras_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageListaCompras;
        }

        private void btIrConta_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageConta;
        }


    }
}
