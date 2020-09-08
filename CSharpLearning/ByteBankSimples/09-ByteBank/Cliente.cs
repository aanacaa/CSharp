﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string CPF
        {
            get { return _cpf; }
            set
            {
                _cpf = value;
            }
        }
        public Cliente (string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;

        }//A inicialização de atributos é a principal responsabilidade do construtor.

    }
}
