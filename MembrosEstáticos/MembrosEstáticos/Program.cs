using System;
using System.Globalization;

namespace MembrosEstáticos
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            //quando crio objetos estáticos, as chamadas dos metodos vêm diretamente da classe
            //NAO PRECISO CRIAR UM OBJETO:Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ =Calculadora.Circunferencia(raio);//metodo chamado direto da classe

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            double volume = Calculadora.Volume(raio);//metodo chamado direto da classe

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));//metodo chamado direto da classe


        }

    }
}
/*
 * também chamados de membros de classe
 * chamados a partir do própiro nome da classe
 * aplicação comuns: classe utilitárias(exemplo: Math.Sqrt), declaração de constantes
 * uma classe eu só tem membros estáticos pode ser chamada classe estática e NÃO PODE SER INSTANCIADA. 
 */
