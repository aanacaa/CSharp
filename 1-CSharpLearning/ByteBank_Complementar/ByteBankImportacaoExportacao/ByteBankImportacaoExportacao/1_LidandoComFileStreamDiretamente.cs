﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                //var textoComQuebraDeLinha = "minha primeira linha \\n minha segunda linha";
                //Console.WriteLine(textoComQuebraDeLinha);
                //Console.ReadLine();

                //var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);


                var buffer = new byte[1024]; // 1 kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);

                }
                // Devoluções:
                //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de 
                //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
                //  zero, se o final do fluxo for atingido
            }

        }


        
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;

            // var utf8 = new UTF8Encoding();
            //var utf8 = new UTF32Encoding();
            var texto = utf8.GetString(buffer, 0, bytesLidos);

            //var texto = utf8.GetString(buffer);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

    }

}