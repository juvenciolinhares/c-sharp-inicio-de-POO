using System;
using System.Globalization;
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto p = new Produto("TV", 500.00, 10);

            //utilizando gets e sets:

            //pegar o nome do produto:
            Console.WriteLine(p.GetNome());

            //atributir(colocar um nome no produto:)
            p.SetNome("T");
            //consigo pegar/ imprimir: mas não consigo adicionaer, alterar através dos atributos
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            
        }
    }
}
