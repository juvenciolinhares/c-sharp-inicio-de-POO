using System;
using System.Globalization;

namespace Construtores
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this()//freferenciando o construtor acima nesse construtor
        {
            Nome = nome;
            Preco = preco;
        }

        //outra opção de reaproveitamento de construtores utilizando o this:
        public Produto(string nome, double preco, int quantidade): this(nome, preco)
        {
            Quantidade= quantidade;
        }
           

        // criar os construtores(SOBRECARGAS DE CONSTRUTORES):

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

