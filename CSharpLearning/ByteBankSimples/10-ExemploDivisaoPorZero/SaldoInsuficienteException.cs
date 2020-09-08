using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ByteBankException
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException //Deste modo, fica fácil saber que a classe é de um tipo de exceção.
    {
        public double Saldo { get; }
        public double ValorSaque { get; }


        public SaldoInsuficienteException()
        {
        }
        //É uma convenção no .NET a criação do construtor sem argumentos para os tipos de exceções.
        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)

        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {
        }

    }
}
