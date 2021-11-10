using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interaçao com usuario
            Console.WriteLine("Digite o numero de produtos a ser registrado: ");
            int x = int.Parse(Console.ReadLine());

            //Criando vetor
            Produto[] vect = new Produto[x + 1];

            for (int i = 1; i < x + 1; i++)
            {
                //Informações dos produtos
                Console.WriteLine("===================================");
                Console.WriteLine($"Produto#{i}");
                Console.WriteLine("Comum, Usado ou Importado (c/u/i)? ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (tipo == "i" || tipo == "I")
                {
                    //Interaçao com usuario
                    Console.WriteLine("Taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    //Adicionando o produto importado ao vetor
                    vect[i] = new Importado(nome, preco, taxa);

                }
                if (tipo == "u" || tipo == "U")
                {
                    //Interaçao com usuario
                    Console.WriteLine("Fabricação: ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());
                    //colocando o produto usado ao vetor
                    vect[i] = new Usado(nome, preco, fabricacao);

                }
                if (tipo == "c" || tipo == "C")
                {
                    //colocando produto comum ao vetor
                    vect[i] = new Comum(nome, preco);

                }

            }
            //Formatando
            Console.WriteLine("===================================");
            Console.WriteLine("");

            //mostrando os produtos e suas informações 
            Console.WriteLine("Etiquetas: ");
            for (int i = 0; i < x + 1; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
