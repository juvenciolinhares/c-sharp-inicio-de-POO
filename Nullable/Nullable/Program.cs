using System;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double x = null;=> o c# não permite

            //usando Nullable:
            Nullable<double> x1 = null;

            //jeito mais simples de escrever:
            double? x = null;
            double? y = 10.0;

            //operações básicas do nullable:
            //1- getvalueOrDefault:
            Console.WriteLine(x.GetValueOrDefault());//pega o valor de x ou padrao
            Console.WriteLine(y.GetValueOrDefault());//imprime o valor de y

            //2- HasValue:
            Console.WriteLine(x.HasValue);//diz se dentro de x tem ou nao um valor => false
            Console.WriteLine(y.HasValue);//diz se dentro de y tem ou nao um valor => true

            //3- Value:
            //Console.WriteLine(x.Value);vai quebrar: erro: objt nullable precisa ter uma valor
            Console.WriteLine(y.Value);

            //forma de resolver:

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y is null");

            /* operador de COALESCÊNCIA NULA:
             double? x = null;
             double y = x ?? 0.0;
             explicação:
             quero jogar x no y, mas caso x seja nulo, quero jogar outro valor.
            */
            double? x2 = null;
            double y2 = 10;

            double a = x ?? 5;// aqui imprime o 5
            double b = y ?? 5;// aqui imprime o valor de y (10)
            Console.WriteLine(a);
            Console.WriteLine(b);




        }
    }
}
