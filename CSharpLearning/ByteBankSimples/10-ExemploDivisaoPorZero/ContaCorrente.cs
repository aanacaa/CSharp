using System;
using System.Diagnostics.Eventing.Reader;


namespace _10_ByteBankException
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public static int TotalDeContasCriadas { get; private set; } //static = Propriedade da classe
        //private readonly int _numero;
        public int Numero { get; }
        //Quando faz dessa forma ja deixa readonly 
        //get
        //{
        //    return _numero;
        //}
        //private set; //Será removido para ninguem poder alterar
        //}

        private double _saldo = 100;
        //Mesma coisa será feita na agencia para deixar o codigo seguro, deixar somente o get
        //private int _agencia;
        public int Agencia
        {
            get;
        }



        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }

            }
        }

        public ContaCorrente(int agencia, int numero)
        {

            if (agencia <= 0)
            {
                //string teste = nameof(agencia); // vai ser "numeroAgencia"

                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(agencia));
            }



            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas; // Não pode dividir por zero

        }//A inicialização de atributos é a principal responsabilidade do construtor.

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;

                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);

                //throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de " + valor);
                //return false;
            }
            _saldo -= valor;
            //return true;

        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
                //throw;
                //throw new Exception("Operação não realizada.", ex);

                //throw new SaldoInsuficienteException("Operação não realizada.");

                //throw ex; // Se deixar o ex na pilha não mostra o erro do Sacar
                //O StackTrace começa quando lançamos a exceção com throw < objeto de exception>;. Desta forma, se usamos esta sintaxe em blocos catch, estaremos perdendo informações da exceção original.
                // O StackTrace na CLR começa quando executamos throw < objeto de exception>; até o manipulador da exceção.
            }
            //if (_saldo < valor)
            //{
            //    //return false;
            //}
            //_saldo -= valor;
            contaDestino.Depositar(valor);
            //return true;

        }

    }
}
