using System;

namespace ResolvendoProblemaSEmOrientacaoAObjeto

{
    internal class Triangulo
    {
        //atributos:
        public double A;
        public double B;
        public double C;

        //Criar um metodo(função dentro da classe, realiza algo)
        public double Area()
        {
            //lógica da área
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));//prceiso importar o using System para chamar o Math

        }

    }
}
/*Projeto de classe UML:
 * primeira parte: Nome;
 * parte do meio: atributos
 * ultima parte: metodos
 */

