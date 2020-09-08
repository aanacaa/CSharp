using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 25;
            int idadeAna = idade;
            idade = 26;
            Console.WriteLine(idade);
            Console.WriteLine(idadeAna);

            Console.ReadLine();
        }
    }
}
