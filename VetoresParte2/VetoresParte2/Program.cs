using System;
using System.Globalization;

namespace VetoresParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vetor que vai armazenr objetos do tipo classe em vez de struct

            Console.Write("Qual a quantidade de produtos?");
            int n = int.Parse(Console.ReadLine());

            //criar o vetor:
            Product[] vect = new Product[n];
            
            //fazer a leitura de cada um dos produtos(nome e preco):
            for(int i = 0; i < n; i++)
            {
                //leitura do nome e preço pra depois instancitar o produto:
                Console.WriteLine("Qual o nome do produto? ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o preço do produto? ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //instanciando o objeto:
                vect[i] = new Product { Name = nome, Price = preco };//instancia automática, sem construtores
            }

            //percorrer o vetor para encontrar o preço médio dos produtos:
            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }
            double media = soma / n;
            Console.WriteLine("Preço médio = " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
