using System;
using System.Globalization;
namespace AutoProperties_Propriedades_
{
    /*
     * ORDEM SUGERIDA PARA IMPLEMENTAÇÃO DOS MEMBROS DE UMA CLASSE:
     * atributos privados + propriedades autoimplementadas
     * construtores
     * Propriedades costumizadas
     * outros métodos da classe.
     */

    
    class Produto
    {
        //atributos + AUTOPROPERTIES:
        
        private string _nome;//obs. não da pra aplica autoproperties no nome por que ele tem uma lógica if
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores:
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //PROPERTIES costumizadaS
        public string Nome
        {
            get { return _nome; }
            set
            {   //value é o parametro que vem de entrada no set: public void SetNome(string nome), nesse caso: nome
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }
              

        //GETS E SETS não são necessários por que ja estão implementados nas properties.

        //METODOS:
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    /*
     * MODIFICADORES DE ACESSO DE CLASSES:
     * public: acessado por qualquer classe
     * 
     * internal(pode vir sem o nome): acessado somente dentro do assembly
     * exemplo: class Produto=> equivale a internal class Produto
     * 
     * private: dá acesso somente pela classe mãe num conjunto de classes aninhadas
     * classe "mais de fora" das classes aninhadas
     * 
     */

}