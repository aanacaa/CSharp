﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
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
            //&& - E
            //|| - OU
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Maior de idade ou está acompanhado");
            }
            else
            {

                Console.WriteLine("Menor de idade");

            }
            Console.ReadLine();
        }
    }
}