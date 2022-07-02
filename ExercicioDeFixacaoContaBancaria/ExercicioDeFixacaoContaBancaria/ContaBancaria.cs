using System;
using System.Globalization;

namespace ExercicioDeFixacaoClassesAtributosMetodos
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        private string Nome { get; set; }
        public double Saldo { get; private set; }
        

        //construtores
        public ContaBancaria()
        {

        }
        public ContaBancaria(int numeroDaConta, string nome)
        {
            NumeroDaConta = numeroDaConta;
            Nome = nome;
        }
        public ContaBancaria(int numeroDaConta, string nome, double depositoInicial) : this(numeroDaConta, nome)
        {
            Depositar(depositoInicial);
        }


        //metodos:

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double valor)
        {
           Saldo = (Saldo - valor) - 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
/*
 * 
 */
