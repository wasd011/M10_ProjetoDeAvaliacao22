using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_ProjetoDeAvaliacao
{
    public class Loja
    {
        public virtual List<Cliente> ListaClientes { get; set; } = new List<Cliente>();
        public virtual List<Produto> ListaProdutos { get; set; } = new List<Produto>();
        public virtual List<Compra> ListaVendas { get; set; } = new List<Compra>();
        public virtual List<ReStock> ListaReStock { get; set; } = new List<ReStock>();

        Cliente ClienteAual { get; set; } = new Cliente();

        String fClientes = "Clientes.txt";
        String fProdutos = "Produtos.txt";
        String fCompras = "Compras.txt";
        String fReStock = "ReStock.txt";


        public class VerificaCLiente
        {
            public static bool NIF(Loja loja, string nifS)
            {
                if (!string.IsNullOrEmpty(nifS) && nifS.Length == 9 && nifS.All(char.IsDigit) && !nifS.Contains("|"))
                {
                    if (loja.ListaClientes.Count > 0)
                    {
                        int nif = Convert.ToInt32(nifS);
                        foreach (Cliente x in loja.ListaClientes)
                        {
                            if (x.nif == nif)
                                return false;
                        }
                        return true;
                    }
                    return true;
                }
                return false;
            }
            public static bool OutraFuncao()
            {
                // Implementação da outra função
                return false;
            }
        }

        public class VerificaProduto
        {
            public static bool VerificarTudo(Loja loja, string nome, string descricao, string categoria, bool editar)
            {
                if (!editar)
                {
                    if (!Loja.VerificaProduto.nome(loja, nome))
                    {
                        MessageBox.Show("Nome do Produto inválido/já usado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (!Loja.VerificaProduto.descricao(descricao))
                {
                    MessageBox.Show("Descrição vazia/inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!Loja.VerificaProduto.categoria(categoria))
                {
                    MessageBox.Show("Categoria vazia/inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

            static bool nome(Loja loja, string nome)
            {
                if (!string.IsNullOrEmpty(nome) && !nome.Contains("|"))
                {
                    if (loja.ListaProdutos.Count > 0)
                    {
                        foreach (Produto x in loja.ListaProdutos)
                        {
                            if (x.nome == nome)
                                return false;
                        }
                        return true;
                    }
                    return true;
                }
                return false;
            }

            static bool descricao(string descricao)
            {
                if (!string.IsNullOrEmpty(descricao) && !descricao.Contains("|"))
                {
                    return true;
                }
                return false;
            }

            static bool categoria(string categoria)
            {
                if (!string.IsNullOrEmpty(categoria) && !categoria.Contains("|"))
                {
                    return true;
                }
                return false;
            }
        }

        public void PegaFicheiros(Loja Loja)
        {
            
            PegaClintes();
            PegaProdutos();
            PegaCompras();
            PegaReStock();

            void PegaClintes()
            {
                try
                {
                    FileStream fileStream = null;

                    if (File.Exists(fClientes))
                        fileStream = new FileStream(fClientes, FileMode.Open, FileAccess.Read);
                    else
                        fileStream = new FileStream(fClientes, FileMode.Create);

                    StreamReader streamReader = new StreamReader(fileStream);

                    while (streamReader.EndOfStream == false)
                    {
                        string[] strings = streamReader.ReadLine().Split("|");

                        Cliente cliente = new Cliente();

                        cliente.nome = strings[0];
                        cliente.morada = strings[1];
                        cliente.dataNascimento = DateTime.ParseExact(strings[2], "dd/MM/yyyy", null);
                        cliente.nif = Convert.ToInt32(strings[3]);
                        cliente.email = strings[4];
                        cliente.numero = strings[5];
                        cliente.senha = strings[6];

                        Loja.ListaClientes.Add(cliente);
                    }
                    fileStream.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao pegar os clientes: " + ex.Message);
                }


            }

            void PegaProdutos()
            {
                try
                {
                    FileStream fileStream = null;

                    if (File.Exists(fProdutos))
                        fileStream = new FileStream(fProdutos, FileMode.Open, FileAccess.Read);
                    else
                        fileStream = new FileStream(fProdutos, FileMode.Create);

                    StreamReader streamReader = new StreamReader(fileStream);

                    while (streamReader.EndOfStream == false)
                    {
                        string[] strings = streamReader.ReadLine().Split("|");

                        Produto produto = new Produto();

                        produto.nome = strings[0];
                        produto.preco = Convert.ToDouble(strings[1]);
                        produto.stock = Convert.ToInt32(strings[2]);
                        produto.descricao = strings[3];
                        produto.categoria = strings[4];
                        produto.verificaDisponibiliade();
                        Loja.ListaProdutos.Add(produto);
                    }
                    fileStream.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao pegar os produtos: " + ex.Message);
                }
            }

            void PegaCompras()
            {
                try
                {
                    FileStream fileStream = null;

                    if (File.Exists(fCompras))
                        fileStream = new FileStream(fCompras, FileMode.Open, FileAccess.Read);
                    else
                        fileStream = new FileStream(fCompras, FileMode.Create);

                    StreamReader streamReader = new StreamReader(fileStream);

                    while (streamReader.EndOfStream == false)
                    {
                        string[] strings = streamReader.ReadLine().Split("|");

                        Compra compra = new Compra();

                        foreach (Cliente x in ListaClientes)
                        {
                            if (x.nif == Convert.ToInt32(strings[0]))
                                compra.comprador = x;
                        }
                        foreach (Produto x in ListaProdutos)
                        {
                            if (x.nome == strings[1])
                                compra.produto = x;
                        }
                        compra.quantidade = Convert.ToInt32(strings[2]);
                        compra.dataCompra = DateTime.ParseExact(strings[3], "dd/MM/yyyy", null);

                        Loja.ListaVendas.Add(compra);
                    }
                    fileStream.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao pegas as compras: " + ex.Message);
                }

            }

            void PegaReStock()
            {
                try
                {
                    FileStream fileStream = null;

                    if (File.Exists(fReStock))
                        fileStream = new FileStream(fReStock, FileMode.Open, FileAccess.Read);
                    else
                        fileStream = new FileStream(fReStock, FileMode.Create);

                    StreamReader streamReader = new StreamReader(fileStream);

                    while (streamReader.EndOfStream == false)
                    {
                        string[] strings = streamReader.ReadLine().Split("|");

                        ReStock reStock = new ReStock();

                        foreach (Produto x in ListaProdutos)
                        {
                            if (x.nome == strings[0])
                                reStock.Produto = x;
                        }
                        reStock.Quantidade = Convert.ToInt32(strings[1]);
                        reStock.Data = DateTime.ParseExact(strings[2], "dd/MM/yyyy", null);

                        Loja.ListaReStock.Add(reStock);

                    }
                    fileStream.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao pegar o reStock: " + ex.Message);
                }

            }
        }

        public void GuardarFicheiros()
        {
            // é precico formatar data antes que vá para o ficheiro ;-; trabalhão
            //File.Delete(fClientes);
            //File.Delete(fProdutos);
            //File.Delete(fCompras);
            //File.Delete(fReStock);

            GuardarClientes();
            GuardarProdutos();
            GuardarCompras();
            GuardarReStock();

            void GuardarClientes()
            {
                try
                {
                    FileStream fileStream = new FileStream(fClientes, FileMode.Create, FileAccess.Write);

                    StreamWriter streamWriter = new StreamWriter(fileStream);

                    foreach (Cliente x in ListaClientes)
                    {
                        DateTime data = x.dataNascimento;
                        string dataFormatada = data.ToString("dd/MM/yyyy");

                        streamWriter.WriteLine(x.nome + "|" + x.morada + "|" + dataFormatada + "|" +
                            x.nif.ToString() + "|" + x.email + "|" + x.numero + "|" + x.senha);
                    }
                    streamWriter.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao guardar os clientes: " + ex.Message);
                }

            }

            void GuardarProdutos()
            {
                try
                {
                    FileStream fileStream = null;

                    fileStream = new FileStream(fProdutos, FileMode.Create, FileAccess.Write);

                    StreamWriter streamWriter = new StreamWriter(fileStream);

                    foreach (Produto x in ListaProdutos)
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

            void GuardarCompras()
            {
                try
                {
                    FileStream fileStream = null;

                    fileStream = new FileStream(fCompras, FileMode.Create, FileAccess.Write);

                    StreamWriter streamWriter = new StreamWriter(fileStream);

                    foreach (Compra x in ListaVendas)
                    {
                        DateTime data = x.dataCompra;
                        string dataFormatada = data.ToString("dd/MM/yyyy");

                        streamWriter.WriteLine(x.comprador.nif.ToString() + "|" + x.produto.nome + "|" +
                            dataFormatada);
                    }
                    streamWriter.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao guardar as compras: " + ex.Message);
                }
            }

            void GuardarReStock()
            {
                try
                {
                    FileStream fileStream = null;

                    fileStream = new FileStream(fReStock, FileMode.Create, FileAccess.Write);

                    StreamWriter streamWriter = new StreamWriter(fileStream);

                    foreach (ReStock x in ListaReStock)
                    {
                        DateTime data = x.Data;
                        string dataFormatada = data.ToString("dd/MM/yyyy");

                        streamWriter.WriteLine(x.Produto.nome + "|" + x.Quantidade.ToString() + "|" +
                            dataFormatada);
                    }
                    streamWriter.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao guardar os reStock: " + ex.Message);
                }
            }
        }

    }
}
