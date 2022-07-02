using System;
using System.Globalization;
namespace ResolvendoProblemaSEmOrientacaoAObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instanciar:

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calcular a área dos triangulos:

            //triangulo x:
            double areaX = x.Area();

            //triangulo y:
            double areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //mostrar maior área:
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}

/*Classe: tipo estruturado que pode conter membro:
 * atributos(dados/campos)
 * metodos(funções/operações)
 * 
 * a classe também pode prover muitos outros recursos:
 * costrutores
 * recargas
 * encapsulamento
 * herança
 * polimorfismo
 * 
 * Exemplos:
 * entidades: protudos, clientes, triangulo
 * serviços: Produtoservice, clienteService
 * Controladores: ProdutoController, ClienteController
 * Utilitarios: Calculadora, compactador
 * Outros: views, repositórios, gerenciadores, etc.
 * 
 * A CLASSE É O FUNDAMENTO PRINCIPAL DA ORIENTAÇÃO A OBJETOS
 * 
 * criar uma classe: gerenciador de soluções-> botão direito no projeto-> adicionar-> classe
 */
