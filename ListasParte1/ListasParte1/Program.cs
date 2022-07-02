using System;
using System.Collections.Generic;// para instanciar uma lista
namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*instancia de uma lista:
             * 1- importo o collections.generics(linha 2)
             * 3- instancio:
             
            List<string> list = new List<string>();//essa lista está vazia

            posso instanciar ja colocando elementos:
            List<string> lista = new List<string>{"alkja", "alka" };
            */

            //metodos que posso utilizar:
            List<string> list = new List<string>();

            /*METODO ADD:
             * adiciona no final da lista
             */

            list.Add("maria");
            list.Add("alex");
            list.Add( "bob");
            list.Add("ana");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");

            /*METODO INSERT:
           * adiciona onde eu quiser
           */
            list.Insert(2, "marco");// na posição dois add o marco
           
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            /*METODO TAMANHO DA LISTA:*/
            Console.WriteLine("Tamanho da lista: " +list.Count);

            Console.WriteLine("------------------------------");

            /*METODO FIND:
           * encontra o primeiro elemento da lista que satisfaça um predicado(expressão lambda)
           */
            string PrimeiroElementoComALetraA = list.Find(x => x[0] == 'a');//quero o obj x talque x na posição 0 seja A

            Console.WriteLine("First 'a' " +PrimeiroElementoComALetraA);

            Console.WriteLine("------------------------------------");

            /*METODO FINDLAST:
          * encontra o ultimo elemento da lista que satisfaça um predicado(expressão lambda)
          */
            string UltimoElementoComALetraA = list.FindLast(x => x[0] == 'a');//quero o obj x talque x na posição 0 seja A

            Console.WriteLine("Last 'a'" + UltimoElementoComALetraA);

            Console.WriteLine("------------------------------------");
            /*METODO FINDINDEX:
           * encontra a primeira posição de um elemento da lista que satisfaça um predicado(expressão lambda)
           * retorna uma posição: numero inteiro int.
           */
            int PrimeiraPosicao = list.FindIndex(x => x[0] == 'a');//quero o obj x talque x na posição 0 seja A

            Console.WriteLine("First Position 'a' " + PrimeiraPosicao);

            Console.WriteLine("------------------------------------");

            /*METODO FINDLASTINDEX:
           * encontra a ultima posição de um elemento da lista que satisfaça um predicado(expressão lambda)
           * retorna uma posição: numero inteiro int.
           */
            int UltimaPosicao = list.FindLastIndex(x=> x[0] =='a');//quero o obj x talque x na posição 0 seja A

            Console.WriteLine("First Position 'a' " + UltimaPosicao);

            Console.WriteLine("------------------------------------");

            /*METODO FINDALL:
           *filtra a lista com base em um predicado(expressão lambda)
           *filtrar uma lista é criar uma outra lista que satisfaz o predicado.
           */
            //declaro uma lista que vai ser o resultado:
            List<string> listFiltro = list.FindAll(x => x.Length == 5);//toda ocorrencia de x com o tamanho 5

            //imprimo a nova lista, ou seja uso foreach:
            foreach (string filtro in listFiltro)
            {
                Console.WriteLine("LIsta filtrada " + filtro);

                Console.WriteLine("------------------------------------");

                /*METODO REMOVE:
              * remove uma string colocada como parametro:
              */
                list.Remove("alex");
                Console.WriteLine("Lista sem o alex:");
                foreach (string semOAlexo in list)
                {
                    Console.WriteLine(semOAlexo);
                }

                Console.WriteLine("------------------------------------");

                /*METODO REMOVEALL:
              * espera como parametro um predicado
              */

                //remover todo mundo que começa com a letra m:
                list.RemoveAll(x => x[0] == 'm');//remove toda string x, talque x na pos 0 seja igual a m
                Console.WriteLine("Lista sem os nomes que começam com m");
                foreach (string semOM in list)
                {
                    Console.WriteLine(semOM);
                }

                Console.WriteLine("------------------------------------");

                /*METODO REMOVEAT:
              * remove um elemento pela posição dele
              */

                //remover o bob pela posição dele
                list.RemoveAt(0);
                Console.WriteLine("lista sem o bob:");
                foreach (string semOBob in list)
                {
                    Console.WriteLine(semOBob);
                }

                Console.WriteLine("------------------------------------");
                list.Add("maria");
                list.Add("alex");
                list.Add("bob");
                list.Add("ana");

                /*METODO REMORANGE:
              * espera uma posição e uma quantia(contagem)
              */
                list.RemoveRange(2, 2);//a partir da posição 2, quero remover 2 elementos:

                foreach(string item in list)
                {
                    Console.WriteLine(item);
                }
               
            }
        }
    }
}
