using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantPessoas = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                if (quantPessoas >= 2)
                {
                    Console.WriteLine("Menor de idade - Acompanhado");
                }
                else
                {
                    Console.WriteLine("Menor de idade");
                }
            }
            Console.ReadLine();
        }
    }
}
