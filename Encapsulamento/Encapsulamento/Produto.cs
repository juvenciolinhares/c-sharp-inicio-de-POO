using System;
using System.Globalization;
namespace Encapsulamento
{
    class Produto
    {
        //atributos, padrão c#: _nome
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Construtores:
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //get e set:

        public string GetNome()
        {
            return _nome;
        }

        /*para quantidade e preço não quero alterar os preços através dos atributos,
         * só altero atraves dos metodos, então não crio os sets, apenas os gets.
         */

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetNome(string nome)
        {
            //no set posso incluir uma lógia para definir regras, exemplo:
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
/*
 * REGRAS DE ENCAPSULAMENTO:
 * todo atributo é privado (private)
 * 
 * 
 */
