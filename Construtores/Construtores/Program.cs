using System;
using System.Globalization;
namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciar o construtor recebendo os paramentros de nome, preco, qtd:
         Produto produto = new Produto(nome, preco);

            //sintaxe alternativa para construtores:
            Produto p2 = new Produto()
            {
                Nome = "TV",
                Preco = 900.00,
                Quantidade = 0
            };
            Produto p3 = new Produto()
            {
                Nome = "TV",
                Preco = 900.00,
                Quantidade = 0

            };





            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
            
        }
    }
}

/*
 */
