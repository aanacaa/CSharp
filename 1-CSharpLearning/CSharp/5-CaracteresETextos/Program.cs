using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5");

            char primeiraLetra = 'a' ;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra+ 1);
            Console.WriteLine(primeiraLetra);


            string titulo = "Ana foi aprovada " + 8500.00;
            Console.WriteLine(titulo);

            string cursos =
                @"- .NET +
- ANGULAR
- PYTHON";

            Console.WriteLine(cursos);

            string vazia = "";
            Console.WriteLine(vazia);

            Console.ReadLine();
        }
    }
}
