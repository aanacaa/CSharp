using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    //[cont][cont][cont][cont][cont]
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens; 
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public ListaDeContaCorrente(int capacidadeInicial =5)//opcional
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }
        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionar item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;


        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            Console.WriteLine("Aumentando capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            //ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                Console.WriteLine(".");
            }
            _itens = novoArray;

        }
        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;

        }


        public void MeuMetodo(string texto = "texto padrao", int numero = 5)
        {

        }

        //public void EscreverListaNaTela()
        //{
        //    for (int i = 0; i < _proximaPosicao; i++)
        //    {
        //        ContaCorrente conta = _itens[i];
        //        Console.WriteLine($"Conta no indice {i} numero {conta.Agencia} {conta.Numero}");
        //    }
        //}

        public ContaCorrente GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        //Indexador
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);

            }
            
        }
        //public ContaCorrente this[string texto]
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}

        // com o params permite adicionar varios
        // public void AdicionarVarios(ContaCorrente[] itens)
        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            //for (int i = 0; i < itens.Length; i++)
            //{
            //    Adicionar(itens[i]);
            //}
            foreach (ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }

        }
        //public void AdicionarVarios(ContaCorrente item1, ContaCorrente item2, ContaCorrente item3)
        //{

        //}

    }

    }
