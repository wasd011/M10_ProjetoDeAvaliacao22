using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace M10_ProjetoDeAvaliacao
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int stock { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }

    }
}
