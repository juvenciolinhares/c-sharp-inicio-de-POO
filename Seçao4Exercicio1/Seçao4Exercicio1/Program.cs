using System;

namespace Seçao4Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ler o nome de duas pessoas
            //mostrar o nome da pessoa mais velha:

            //instanciar 
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            //nome e idade da pessoa a:
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());


            //nome e idade da pessoa b:
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa");
            Console.Write("Nome: ");
            b.idade = int.Parse(Console.ReadLine());
                        
            //verificar maior idade:
            if(a.idade > b.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }


        }
    }
}
