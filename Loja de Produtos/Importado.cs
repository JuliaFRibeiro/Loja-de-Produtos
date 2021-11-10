using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Produtos
{
    class Importado : Produto
    {

        //declarando variaveis
        public double Taxa { get; set; }
        //Construtores
        public Importado() { }
        public Importado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Taxa = taxa;
        }
        //To String com a variavel taxa 
        public override string ToString()
        {
            return Nome + " - " + Preco + " - " + $"(Taxa: {Taxa})";
        }
    }
}
