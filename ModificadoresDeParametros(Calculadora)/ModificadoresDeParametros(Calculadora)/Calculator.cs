

namespace ModificadoresDeParametros_Calculadora_
{
    /*MODIFICADOR DE PARÂMETROS PARAMS:*/
    internal class Calculator
    {
      public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

            }
            return sum;
        }
    }
}
/*MODIFICADOR DE PARÂMETROS PARAMS:
 * avisa ao compilador que eu quero receber uma QUANTIA VARIÁVEL DE VALORES
 */
