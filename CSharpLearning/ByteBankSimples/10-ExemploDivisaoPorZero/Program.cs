using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ByteBankException
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CarregarContas();
            }
            catch
            {
                Console.WriteLine("catch no Main ");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");

            Console.ReadLine();
        }

        private static void CarregarContas()
        { //Para usarmos o bloco using com o código using (RecursoDoSistema recurso = new RecursoDoSistema()) { … }, é necessário que o RecursoDoSistema implemente a interface IDisposable.
            // Com o bloco using, a instanciação do objeto acontece em um bloco try e no bloco finally o método Dispose é invocado após a verificação de referência nula.
             using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                //Using pede o IDisposable
                leitor.LerProximaLinha();
            }

            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contasL.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finaly");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 4578420);
            //    ContaCorrente conta2 = new ContaCorrente(485, 456478);

            //    conta2.Transferir(10000, conta);
            //    //conta.Depositar(50);
            //    //Console.WriteLine(conta.Saldo);
            //    //conta.Sacar(-500);
            //    //Console.WriteLine(conta.Saldo);

            //}

            //catch (ArgumentException ex)
            //{
            //    if (ex.ParamName == "numero")
            //    {

            //    }
            //    Console.WriteLine("Argumento com problema: "+ ex.ParamName);
            //    Console.WriteLine("Ocorreu uma ArgumentException: ");

            //    Console.WriteLine(ex.Message);


            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine("Saldo:" + ex.Saldo);
            //    Console.WriteLine("ValorSaque: " + ex.ValorSaque);
            //    Console.WriteLine("StackTrace: " + ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Exceção do SaldoInsuficienteException");

            //} 
        }


        private static void TestaArgumentException()
        {
            try
            {
                //Metodo();
                ContaCorrente conta = new ContaCorrente(0, 550);

            }
            //catch (DivideByZeroException e) //Precisa ficar antes daquela outra que tem todas 
            //{
            //    Console.WriteLine("Não é possível fazer uma divisão por 0!");
            //}
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro");
            }

        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
