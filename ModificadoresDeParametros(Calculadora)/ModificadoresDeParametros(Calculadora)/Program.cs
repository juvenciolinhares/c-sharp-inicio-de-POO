using System;

namespace ModificadoresDeParametros_Calculadora_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);//posso colocar quantos valores quiser
            Console.WriteLine(s1);

            int s2 = Calculator.Sum(2, 3, 4);
            int s3 = Calculator.Sum(2, 3, 4, 20, 49, 20);
            int s4 = Calculator.Sum(2, 3, 4, 2, 5, 6, 4, 3, 2, 4);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);


        }
    }
}
