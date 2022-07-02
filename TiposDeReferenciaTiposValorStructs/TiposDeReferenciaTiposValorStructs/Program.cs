using System;

namespace TiposDeReferenciaTiposValorStructs
{
    /*
     * criar um struct: adiciona uma classe normal, depois troca o nome class por struct
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;// não preciso "completar" com o new Point(); por que NÃO É UMA CLASSE, MAS SIM UM STRUCT
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            // mesmo sem precisar do new Point(); o tipo struct aceita o comando new:
            p = new Point();// imprime(0,0)
            Console.WriteLine(p);

            /*
             * CONCLUSÃO:
             * mesmo sendo um tipo struct eu tenho que inicializar
             * ou colocando valores: 
             * p.X = 10;
             * p.Y = 20;
             * 
             * ou fazendo o new():
             *  p = new Point();
             */

        }
    }
}

