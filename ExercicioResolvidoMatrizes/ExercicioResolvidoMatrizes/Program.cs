using System;

namespace ExercicioResolvidoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero n");
            int n = int.Parse(Console.ReadLine());

            //instanciar a matriz:
            int[,] mat = new int[n, n];

            //guardar elementos na matriz:
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("digite os valores da linha " + i);
                //crio um vetor para receber os valores da linha e separo esses valores com o split:
                string[] valor = Console.ReadLine().Split(' ');
                
                for(int j = 0; j < n; j++)
                {
                    //percorrer o vetor valores guardando cada um dos elementos
                    
                    //matriz ij recebe na posição j o int o vetor valor
                    mat[i, j] = int.Parse(valor[j]);
                }
            }
            //encontrar a diagonal principal:
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            //encontrar os numero negativos:

            int count = 0;//crio um contador
            //percorrer a matriz inteira e encontrar os numero negativos e adicionar ao contador
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        count++;
                    }

                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
}
