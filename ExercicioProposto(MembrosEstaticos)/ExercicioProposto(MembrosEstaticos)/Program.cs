using System;
using System.Globalization;

namespace ExercicioProposto_MembrosEstaticos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            ConversorDeMoedas.cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.ValorASerPagoEmReais(dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
/*ler a cotação do dolar
* valor a ser comprado em reais 
* informar quantos reais vai pagar pelos dolares
* 6% iof sobre o dolar
* */
