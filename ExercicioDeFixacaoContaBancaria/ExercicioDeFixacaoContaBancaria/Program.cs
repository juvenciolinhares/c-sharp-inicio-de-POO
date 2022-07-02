using System;
using System.Globalization;
namespace ExercicioDeFixacaoClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial?(s/n)");
            char resposta = char.Parse(Console.ReadLine());

            double depositoInicial;
            if (resposta == 's' || resposta == 'S')
            {

                Console.Write("Entre o valor do deposito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine(conta);

            //depósito:
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            //saque:
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
