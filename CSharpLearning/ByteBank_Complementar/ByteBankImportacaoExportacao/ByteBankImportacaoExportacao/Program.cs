using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {

            var enderecoDoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);


            var buffer = new byte[1024]; // 1 kb
            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);

            }
            // Devoluções:
            //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de 
            //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
            //  zero, se o final do fluxo for atingido


            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
} 
 