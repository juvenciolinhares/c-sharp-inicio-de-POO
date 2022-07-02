using System;

namespace ExercicioFixacaoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de linhas e colunas da matriz:");
            string[] linhasEColunas = Console.ReadLine().Split(' ');
            int m = int.Parse((linhasEColunas[0]));
            int n = int.Parse((linhasEColunas[1]));

            //instanciar a matriz:
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os valores: ");
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Escolha um numero da matriz");
            int x = int.Parse(Console.ReadLine());

            //saber a posição e números ao redor:
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ": ");
                        
                        if(j > 0)//limite da matriz 
                        {
                            Console.WriteLine("Left: " + matriz[i, j -1]);
                        }
                        if(i> 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if(i < m - 1) 
                        {
                            Console.WriteLine("Down: " + matriz[i+ 1, j ]);
                        }
                    }
                }
            }
            
        }
    }
}
