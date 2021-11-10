using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Produtos
{
    class Usado : Produto
    {
        //declarando variaveis
        public DateTime Fabricacao { get; set; }

        //Construtores
        public Usado() { }
        public Usado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Fabricacao = fabricacao;
        }
        //To Strig com a variavel fabricacao
        public override string ToString()
        {
            return Nome + " - " + Preco + " - " + $"(fabricado: {Fabricacao.ToString("dd/MM/yyyy")})";
        }

    }
}
