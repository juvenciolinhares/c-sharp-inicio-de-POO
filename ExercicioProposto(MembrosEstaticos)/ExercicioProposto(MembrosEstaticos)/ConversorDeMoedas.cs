using System;
using System.Globalization;

namespace ExercicioProposto_MembrosEstaticos_
{
    internal class ConversorDeMoedas
    {
        public static double cotacao;
        public static double Iof = 6.0;

        public static double ValorASerPagoEmReais(double dolares)
        {
            double total = dolares * cotacao;
            return total + total * Iof / 100;
        }


    }
}

/*ler a cotação do dolar
* valor a ser comprado em reais 
* informar quantos reais vai pagar pelos dolares
* 6% iof sobre o dolar
* */
