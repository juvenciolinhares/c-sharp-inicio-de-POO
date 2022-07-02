using System;
using System.Globalization;

namespace ProdutoSegundoProblemaExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int quantidade =int.Parse(Console.ReadLine());
           
            //usando a função de adicionar produtos:
            produto.AdicionarProdutos(quantidade);
            
            Console.WriteLine();
            Console.WriteLine("Dado atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido no estoque: ");
            quantidade =int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            Console.WriteLine("Dado atualizados: " + produto);



        }
    }
}
