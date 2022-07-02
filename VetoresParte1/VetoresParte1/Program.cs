using System;
using System.Globalization;

namespace VetoresParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que lê altura de n pessoas e retorna a altura média:

            int n = int.Parse(Console.ReadLine());
            
            //instacio um vetor que vai ter o n como tamanho
            double[] vect = new double[n];

            //crio um for pra percorrer o vetor:
            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            //fazer a soma das alturas:
            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            //fazer a média:
            double media = soma / n;
            Console.WriteLine("AVERAGE HEIGHT = " +media.ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
