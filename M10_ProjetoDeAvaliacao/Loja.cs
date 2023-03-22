using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_ProjetoDeAvaliacao
{
    public class Loja
    {
        public virtual List<Cliente> ListaClientes { get; set; } = new List<Cliente>();
        public virtual List<Produto> ListaProdutos { get; set; } = new List<Produto>();


        public bool verificaNIF(int nif)
        {
            if(nif.ToString().Length == 9)
            {
                foreach (Cliente x in ListaClientes)
                {
                    if (x.nif == nif)
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
