using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_ProjetoDeAvaliacao
{
    public class Cliente
    {
        public Cliente(string nome, string morada, DateTime dataNascimento, int nIF, string email, string numero, string senha)
        {
            this.nome = nome;
            this.morada = morada;
            this.dataNascimento = dataNascimento;
            this.nif = nIF;
            this.email = email;
            this.numero = numero;
            this.senha = senha;
        }

        public Cliente()
        {

        }

        public string nome { get; set; }
        public string morada { get; set; }
        public DateTime dataNascimento { get; set; }
        public int nif { get; set; }
        public string email { get; set; }
        public string numero { get; set; }
        public string senha { get; set; }
    }
}
