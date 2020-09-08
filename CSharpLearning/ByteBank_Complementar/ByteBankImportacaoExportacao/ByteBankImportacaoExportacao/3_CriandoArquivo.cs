﻿using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,7895,4785.40, Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas2.csv";
            //Cria um novo, mas se existir mostra um erro 
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            //Sobreescreve o arquivo
            //using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,65465,456.0,Pedro");
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    //Ao abrir o arquivo ainda está vazio, somente quando termina que enche o arquivo
                    //Por isso vamos usar o Flush
                    escritor.Flush(); // Despeja o buffer para o Stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }

            }
        }

    }
}