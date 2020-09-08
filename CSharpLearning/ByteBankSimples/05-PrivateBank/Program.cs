using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PrivateBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            bool resultaDoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(resultaDoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);



            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Antes: Saldo Do Bruno R$ " + contaDoBruno.saldo);
            Console.WriteLine("Antes: Saldo Da Gabriela R$ " + contaDaGabriela.saldo);

            bool resultadoTranferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Resultado Tranferencia: " + resultadoTranferencia);

            Console.WriteLine("Saldo Do Bruno R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Da Gabriela R$ " + contaDaGabriela.saldo);


            bool resultadoTranferenciaNovo = contaDaGabriela.Transferir(10, contaDoBruno);
            Console.WriteLine("Resultado Tranferencia: " + resultadoTranferenciaNovo);

            Console.WriteLine("Saldo Do Bruno R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Da Gabriela R$ " + contaDaGabriela.saldo);


            Console.ReadLine();

        }
    }
}
