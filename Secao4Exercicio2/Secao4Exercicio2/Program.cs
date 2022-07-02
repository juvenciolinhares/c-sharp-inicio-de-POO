﻿using System;
using System.Globalization;
namespace Secao4Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //instanciar funcionários
           Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            // dados dos funcionarios:
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculo da média dos salários:

            double media = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
