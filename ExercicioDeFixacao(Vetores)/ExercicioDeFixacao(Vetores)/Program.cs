using System;

namespace ExercicioDeFixacao_Vetores_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*dez quartos a serem alugados com numeros de 0 a 9
             * inciar os 10 quartos vazios
             * ler uma qtd n de alunos que vao alugar os quartos
             * registrar qual o quarto que o estudante alugou(0 a 9)
             * informar nome, email, qual quarto escolheu
             * imprimir as ocupaçoes na ordem crescente de quartos
             */
            //instanciou  o vetor estudante:
            Estudante[] vet = new Estudante[10];

            //interação do programa:
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #{0}: ", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("email: ");
                string email = Console.ReadLine();
                Console.WriteLine("quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            for (int i = 1; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }

        }

    }
}
