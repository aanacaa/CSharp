using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8  - Condicionais2");

            int idadeJoao = 16;
            int quantPessoas = 2;
            //bool acompanhado = true;
            bool acompanhado = quantPessoas >= 2;
            string mensagemAdicional;

            //Digitar if e clicar tab duas vezes, deixe amarelo e aperte enter no fim da condicional que cai para linha da regra
            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";

            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }
            //&& - E
            //|| - OU
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Maior de idade ou está acompanhado");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {

                Console.WriteLine("Menor de idade");

            }
            Console.ReadLine();
        }
    }
}
