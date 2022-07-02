using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declaração de matriz:

          //diz que é bidi       diz a qtd de linhas e colunas
            double[,] mat = new double[2, 3];

            //propriedades:

            //length:
            Console.WriteLine(".length: total de elementos da matriz: " +mat.Length);

            //rank:
            Console.WriteLine(".Rank diz a primeira dimensão da matriz(qtd de linhas): " +mat.Rank);

            //GetLength
            Console.WriteLine("A primeira dimensão da matriz(dimensão 0), que são as linhas, tem o tamanho: " + mat.GetLength(0));
            Console.WriteLine("A segunda dimensão da matriz(dimensão 1), que são as colunas, tem o tamanho: " + mat.GetLength(1));
        }
    }
}
/*
 * MATRIZES: 
 * arranjos bidimenssionais(linhas, colunas)
 * homogenea, ordenada e alocada de uma vez só (igual aos vetores)
 * 
 * vantagens: acesso imediato através do index(posição)
 * 
 * desvantagens:
 * tamanho fixo, dificuldade p adicionar e excluir elementos
 */
