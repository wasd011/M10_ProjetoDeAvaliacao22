using System;
using System.Collections.Generic;
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



        public bool verificaNIF(int nif)
        {
            if (ListaClientes.Count > 0)
            {
                foreach (Cliente x in ListaClientes)
                {
                    if (x.nif == nif)
                        return false;
                }
                return true;
            }
            return true;
        }

        public void PegaFicheiros()
        {
            String fClientes = "Clientes.txt";
            String fProdutos = "Produtos.txt";
            String fCompras = "Compras.txt";
            String fReStock = "ReStock.txt";

            PegaClintes();
            PegaProdutos();
            PegaCompras();
            PegaReStock();

            void PegaClintes()
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

                    ListaClientes.Add(cliente);
                }
                fileStream.Dispose();

            }

            void PegaProdutos()
            {
                FileStream fileStream = null;

                if (File.Exists(fProdutos))
                    fileStream = new FileStream(fClientes, FileMode.Open, FileAccess.Read);
                else
                    fileStream = new FileStream(fClientes, FileMode.Create);

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
                    produto.subCategoria = strings[5];
                    produto.verificaDisponibiliade();
                    ListaProdutos.Add(produto);                    
                }
                fileStream.Dispose();
            }

            void PegaCompras()
            {
                FileStream fileStream = null;

                if (File.Exists(fCompras))
                    fileStream = new FileStream(fClientes, FileMode.Open, FileAccess.Read);
                else
                    fileStream = new FileStream(fClientes, FileMode.Create);

                StreamReader streamReader = new StreamReader(fileStream);

                while (streamReader.EndOfStream == false)
                {
                    string[] strings = streamReader.ReadLine().Split("|");

                    Compra compra = new Compra();

                    foreach(Cliente x in ListaClientes)
                    {
                        if (x.nif == Convert.ToInt32(strings[0]))
                            compra.comprador = x;
                    }
                    foreach(Produto x in ListaProdutos)
                    {
                        if(x.nome == strings[1])
                            compra.produto = x;
                    }
                    compra.quantidade = Convert.ToInt32(strings[2]);
                    compra.dataCompra = DateTime.ParseExact(strings[3], "dd/MM/yyyy", null);

                    ListaVendas.Add(compra);
                }
                fileStream.Dispose();
            }

            void PegaReStock()
            {
                FileStream fileStream = null;

                if (File.Exists(fReStock))
                    fileStream = new FileStream(fClientes, FileMode.Open, FileAccess.Read);
                else
                    fileStream = new FileStream(fClientes, FileMode.Create);

                StreamReader streamReader = new StreamReader(fileStream);

                while (streamReader.EndOfStream == false)
                {
                    string[] strings = streamReader.ReadLine().Split("|");

                    ReStock reStock = new ReStock();

                    foreach(Produto x in ListaProdutos)
                    {
                        if (x.nome == strings[0])
                            reStock.Produto = x;
                    }
                    reStock.Quantidade = Convert.ToInt32(strings[1]);
                    reStock.Data = DateTime.ParseExact(strings[2], "dd/MM/yyyy", null);

                    ListaReStock.Add(reStock);

                }
                fileStream.Dispose();
            }
        }

        public void GuardarFicheiros()
        {
            // é precico formatar data antes que vá para o ficheiro ;-; trabalhão

            String fClientes = "Clientes.txt";
            String fProdutos = "Produtos.txt";
            String fCompras = "Compras.txt";
            String fReStock = "ReStock.txt";

            GuardarClientes();
            GuardarProdutos();
            GuardarCompras();
            GuardarReStock();

            void GuardarClientes()
            {
                FileStream fileStream = null;

                fileStream = new FileStream(fClientes, FileMode.Create, FileAccess.Write);

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

            void GuardarProdutos()
            {
                FileStream fileStream = null;

                fileStream = new FileStream(fProdutos, FileMode.Create, FileAccess.Write);

                StreamWriter streamWriter = new StreamWriter(fileStream);

                foreach (Produto x in ListaProdutos)
                {
                    streamWriter.WriteLine(x.nome + "|" + x.preco.ToString() + "|" + x.stock.ToString() + 
                        "|" + x.descricao + "|" + x.categoria + "|" + x.subCategoria);
                }
                streamWriter.Dispose();
            }

            void GuardarCompras()
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

            void GuardarReStock()
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
        }

    }
}
