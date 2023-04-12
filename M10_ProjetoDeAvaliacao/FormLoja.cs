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
    public partial class FormLoja : Form
    {
        Loja Loja = new Loja();
        bool editarP = false;
        int indexP = -1;
        public FormLoja()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        public FormLoja(Loja loja)
        {
            //this.Loja = loja;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void FormLoja_Load(object sender, EventArgs e)
        {
            Loja.PegaFicheiros(Loja);
            string nC = Loja.ListaClientes.Count.ToString(), nP = Loja.ListaProdutos.Count.ToString();
            string nV = Loja.ListaVendas.Count.ToString(), nRT = Loja.ListaReStock.Count.ToString();

            MessageBox.Show("nº clientes:" + nC +
                "\nnº produtos: " + nP +
                "\nnº vendas: " + nV +
                "\nnº reStock: " + nRT);
            AtualizarDGVClientes();
            AtualizarDGVProduto();
            AtualizarDGVVendas();
            AtualizarDGVReStock();
            AtualizaCBReStockProduto();

        }

        private void FormLoja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loja.GuardarFicheiros();
            Form form = new Form1();
            form.Show();
            this.Dispose();
        }

        private void btAddProduto_Click(object sender, EventArgs e)
        {
            if (Loja.VerificaProduto.VerificarTudo(Loja, tbNomeP.Text, rTbDescricao.Text, tbCategoriaP.Text, editarP))
            {
                Produto p = new Produto();
                p.nome = tbNomeP.Text;
                p.preco = (double)nupPrecoP.Value;
                p.stock = (int)nupStockP.Value;
                p.descricao = rTbDescricao.Text;
                p.categoria = tbCategoriaP.Text;
                Loja.ListaProdutos.Add(p);

                AtualizarDGVProduto();
                LimparProduto();
                AtualizaCBReStockProduto();

                tabPrincipal.SelectedTab = tabPageProduto;
                tabControlProduto.SelectedTab = tabPageListaProdutos;
            }
        }
        private void btAddReStock_Click(object sender, EventArgs e)
        {
            if (Loja.ListaProdutos.Count < 0)
            {
                MessageBox.Show("Crie um produto primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbProdutoReStock.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReStock rS = new ReStock();
            rS.Produto = Loja.ListaProdutos[cbProdutoReStock.SelectedIndex];
            rS.Quantidade = (int)nupQuantidadeReStock.Value;
            rS.Data = DateTime.ParseExact(DateTime.Today.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
            Loja.ListaReStock.Add(rS);

            Loja.ListaProdutos[cbProdutoReStock.SelectedIndex].stock += rS.Quantidade;
            AtualizarDGVReStock();
            AtualizarDGVProduto();
            LimparReStock();

            tabPrincipal.SelectedTab = tabPageReStock;
            tabControlReStock.SelectedTab = tabPageListaReStock;
        }




        void AtualizarDGVProduto()
        {
            dgvListaProdutos.Rows.Clear();

            foreach (Produto x in Loja.ListaProdutos)
            {
                x.verificaDisponibiliade();
                dgvListaProdutos.Rows.Add(x.nome, x.preco, x.stock, x.descricao, x.categoria, x.disponivel);
            }

        }
        void AtualizarDGVClientes()
        {
            dgvListaClientes.Rows.Clear();

            if (Loja.ListaClientes.Count > 0)
            {
                foreach (Cliente x in Loja.ListaClientes)
                {
                    dgvListaClientes.Rows.Add(x.nome, x.morada, x.dataNascimento, x.nif, x.email,
                        x.numero);
                }
            }
        }
        void AtualizarDGVVendas()
        {
            dgvListaVendas.Rows.Clear();

            if (Loja.ListaVendas.Count > 0)
            {
                foreach (Compra x in Loja.ListaVendas)
                {
                    dgvListaVendas.Rows.Add(x.comprador.nome, x.produto.nome, x.quantidade, x.dataCompra);
                }
            }
        }
        void AtualizarDGVReStock()
        {
            dgvListaReStock.Rows.Clear();

            if (Loja.ListaReStock.Count > 0)
            {
                foreach (ReStock x in Loja.ListaReStock)
                {
                    dgvListaReStock.Rows.Add(x.Produto.nome, x.Quantidade, x.Data);
                }
            }
        }

        void AtualizaCBReStockProduto()
        {
            cbProdutoReStock.Items.Clear();

            if (Loja.ListaProdutos.Count > 0)
            {
                foreach (Produto x in Loja.ListaProdutos)
                {
                    cbProdutoReStock.Items.Add(x.nome + " | " + x.preco.ToString() + "€ | " + x.stock.ToString() + " | " + x.categoria);
                }
            }
        }

        void LimparProduto()
        {
            tbNomeP.Text = string.Empty;
            nupPrecoP.Value = nupPrecoP.Minimum;
            nupStockP.Value = nupStockP.Minimum;
            rTbDescricao.Text = string.Empty;
            tbCategoriaP.Text = string.Empty;
            editarP = false;
            tbNomeP.Enabled = true;
            btAlterarProduto.Enabled = false;
            btAddProduto.Enabled = true;
            indexP = -1;
        }

        void LimparReStock()
        {
            cbProdutoReStock.SelectedIndex = -1;
            nupQuantidadeReStock.Value = nupQuantidadeReStock.Minimum;
        }

        void GuardaProduto()
        {
            try
            {
                FileStream fileStream = null;

                fileStream = new FileStream("Produtos.txt", FileMode.Create, FileAccess.Write);

                StreamWriter streamWriter = new StreamWriter(fileStream);

                foreach (Produto x in Loja.ListaProdutos)
                {
                    streamWriter.WriteLine(x.nome + "|" + x.preco + "|" + x.stock +
                        "|" + x.descricao + "|" + x.categoria);
                }
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao guardar os produtos: " + ex.Message);
            }
        }
    }
}
