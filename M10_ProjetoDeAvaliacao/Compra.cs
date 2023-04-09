using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_ProjetoDeAvaliacao
{
    public class Compra
    {
        public Compra(Cliente comprador, Produto produto,int quantidade, DateTime dataCompra)
        {
            this.comprador = comprador;
            this.produto = produto;
            this.quantidade = quantidade;
            this.dataCompra = dataCompra;
        }

        public Compra()
        {

        }
        public Cliente comprador { get; set; }
        public Produto produto { get; set; }
        public int quantidade { get; set; }
        public DateTime dataCompra { get; set; }
    }
}
