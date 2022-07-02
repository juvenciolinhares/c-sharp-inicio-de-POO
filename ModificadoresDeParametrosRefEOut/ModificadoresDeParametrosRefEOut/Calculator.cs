using System;


namespace ModificadoresDeParametrosRefEOut
{
    internal class Calculator
    {
        //criar um método que triplique o numero
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        //MODIFICADOR DE PARAMETRO OUT
        public static void TripleOut(int origem, out int resultado)// rebeco uma origem, resultado é o retorno do metodo
        {
            resultado = origem * 3;
        }
    }
}
