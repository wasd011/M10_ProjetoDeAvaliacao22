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
        public Produto(string nome, double preco, int stock, string descricao, string categoria, string subCategoria)
        {
            this.nome = nome;
            this.preco = preco;
            this.stock = stock;
            this.descricao = descricao;
            this.categoria = categoria;
            this.subCategoria = subCategoria;
            verificaDisponibiliade();
        }

        public Produto() 
        {

        }


        public string nome { get; set; }
        public double preco { get; set; }
        public int stock { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public bool disponivel { get; set; }
        

        public void verificaDisponibiliade()
        {
            if(this.stock > 0)
                this.disponivel = true;
            else
                this.disponivel = false;
        }
        public void Venda(int quantidade)
        {
            if (this.disponivel && this.stock >= quantidade)
            {
                this.stock =- quantidade;
                verificaDisponibiliade();
            }
        }
    }
}
