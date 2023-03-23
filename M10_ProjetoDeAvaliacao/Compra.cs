using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_ProjetoDeAvaliacao
{
    public class Compra
    {
        public Compra(Cliente comprador, Produto produto, DateTime dataCompra)
        {
            this.comprador = comprador;
            this.produto = produto;
            this.dataCompra = dataCompra;
        }

        public Cliente comprador { get; set; }
        public Produto produto { get; set; }
        public DateTime dataCompra { get; set; }
    }
}
