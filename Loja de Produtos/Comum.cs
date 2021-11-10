using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Produtos
{
    class Comum : Produto
    {
        //Construtores
        public Comum() { }
        public Comum(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        //To string dos produtos comuns
        public override string ToString()
        {
            return Nome + " - " + Preco;
        }
    }
}
