using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; } //Somente leitura
        private readonly string _argumentos; //Somente leitura

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }



            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            // é indicado colocar o url ao inves do URL pois algum pode manipular e estragar  a logica
            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; // moedaDestino=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); // x

            //string resultado = argumentoEmCaixaAlta.Substring(indiceTermo + termo.Length);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dolar

            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }
            else
            {
                return resultado.Remove(indiceEComercial);
            }

            //return _argumentos.Substring(indiceTermo + termo.Length);

            // int indiceParametro = _argumentos.IndexOf


            //int indiceParametro = _argumentos.IndexOf

        }



    }
}
