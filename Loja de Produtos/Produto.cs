using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Produtos
{
    abstract class Produto
    {
        //declarando variaveis
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtores
        public Produto() { }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //To string para etiquetas 
        public override string ToString()
        {
            return Nome + " - " + Preco;
        }
    }
}
