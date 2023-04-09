using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_ProjetoDeAvaliacao
{
    public class ReStock
    {
        public ReStock(Produto produto, int quantidade, DateTime data)
        {
            Produto = produto;
            this.Quantidade = quantidade;
            this.Data = data;
        }

        public ReStock() 
        {
            
        }

        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }

    }
}
