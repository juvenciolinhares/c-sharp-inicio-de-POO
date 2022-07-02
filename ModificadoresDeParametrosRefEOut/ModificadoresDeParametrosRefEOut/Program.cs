using System;

namespace ModificadoresDeParametrosRefEOut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*MODIFICADOR DE PARAMETRO "REF"
             * criar um método que triplique o numero:
             * usa a palavra reservado "ref" que vai fazer com que o paramatro da função 
             * se torne uma referencia de a e altere esse a.
             */
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //MODIFICADOR DE PARAMETRO "OUT"

            //1- declaro uma variavel "de entrada"
            int b = 10;

            //2- declaro uma variável de saída(retorno do método)
            int triplo; 

            //3- chamo o método da classe passando como parametro a var de entrada, out (variavel de saída= triplo)
            Calculator.TripleOut(b, out triplo);
            Console.WriteLine(triplo);
        }
    }

    /*
     * Diferença entre ref e out:
     * 1- no ref a variável PASSADA COMO PARÂMETRO tem que ter sido iniciada, no out não.
     * 
     * ambos são considerados code smell(código ruim) e devem ser evitados.
     */
}
