using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.ListExtensoes;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //ContaCorrente conta = new ContaCorrente(847, 489754);
            //FuncionarioAutenticavel carlos = null;
            //Console.WriteLine(conta.Numero);
            //VerificaVencimento();
            //AnaliseURL();
            //AnaliseRegex();
            //UsoEquals();
            //UsoObjectEToString();
            //TestaArrayInt();
            //TestaArraydeContaCorrente();
            //TestaListaDeContaCorrente();
            //Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            //Console.WriteLine(SomarVarios(1, 2, 45));
            // TestaListaDeObject
            //TestaListaGenerica()
            //UsoDoVar()
            // TestaSort()

            //var meses = new List<string>() { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
            //var mesesOrdenados = meses.OrderBy(mes => mes);

            var contas = new List<ContaCorrente>()
            {
                    new ContaCorrente(341, 1),
        new ContaCorrente(342, 999),
        null,
        new ContaCorrente(340, 4),
        new ContaCorrente(340, 456),
        new ContaCorrente(340, 10),
        null,
        null,
        new ContaCorrente(290, 123)
            };

            // contas.Sort();// ~~> Chama a implementação dada em IComparable
            //contas.Sort(new ComparadorContaCorrentePorAgencia());
            //contas.Sort();
            //IOrderedEnumerable<ContaCorrente> contasOrdenadas =
            //    contas.OrderBy(conta => conta.Numero); //isso é uma expressão lambida
            //    IOrderedEnumerable<ContaCorrente> contasOrdenadas  =
            //contas.OrderBy(conta => {
            //    if (conta == null)
            //    {
            //        return int.MaxValue;
            //    }

            //    return conta.Numero;
            //});


            //foreach (var conta in contas)
            //foreach (var conta in contasOrdenadas)
            //{
            //    if (conta != null) { 

            //        Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            //    }
            //}
            //var listaSemNulos = new List<ContaCorrente>();
            //foreach (var conta in contas)
            //{
            //    if (conta != null)
            //    {
            //        listaSemNulos.Add(conta);
            //    }
            //}

            //var contasNaoNulas = contas.Where(conta => conta != null);
            //true quando conta deve ser adicionada à coleção contasNaoNulas;
            //false quando conta não deve ser adicionada à coleção contasNaoNulas.


            //IOrderedEnumerable<ContaCorrente> contasOrdenadas =
            //contas.OrderBy(conta => conta.Numero);
            //IOrderedEnumerable<ContaCorrente> contasOrdenadas =
            //    contasNaoNulas.OrderBy(conta => conta.Numero);

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas =
            //contasNaoNulas.OrderBy<ContaCorrente, int>(conta => conta.Numero);
            //var contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas
            //    .Where(conta => conta != null)
            //    .OrderBy<ContaCorrente, int>(conta => conta.Numero);

            //var contasOrdenadas = contas
            //    .Where(conta => conta != null)
            //    .OrderBy<ContaCorrente, int>(conta => conta.Numero);
            var contasOrdenadas = contas
               .Where(conta => conta != null)
               .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }
            Console.ReadLine();




        }

        static void TestaSort()
        {


            List<int> idades = new List<int>();

            idades.Add(51);
            idades.Add(5);
            idades.Add(14);
            idades.Add(88);
            idades.Add(38);
            idades.Add(61);
            //idades.Remove(5);
            //idades.AddRange(new int[] { 1, 2, 3, 9 });
            //ListExtensoesOld.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);
            //idades.AdicionarVarios(5454, 46, 54);
            idades.AdicionarVarios(5, 448, 7898, 4564);
            idades.AdicionarVarios(99, -1);

            idades.Sort();



            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            //var nomes = new List<string>();

            //nomes.AdicionarVarios("Guilherme", "Luana");
            var nomes = new List<string>()
            {
                "Guilherme",
                "Luana",
                "Wellington",
                "Ana"
            };
            nomes.AdicionarVarios("zuilherme", "buana");

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }



        }
        static void UsoDoVar()
        {

            //Declarações uso do var
            List<int> idades = new List<int>();
            ContaCorrente conta;
            //conta.Depositar(50);//precisa inicializar
            conta = new ContaCorrente(344, 56456556);
            ContaCorrente conta2 = new ContaCorrente(344, 56456556);//mais comum 
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            List<GerenciadorBonificacao> gerenciadores = new List<GerenciadorBonificacao>();
            ContaCorrente conta3 = new ContaCorrente(344, 56456556);
            List<GerenciadorBonificacao> gerenciadores2 = new List<GerenciadorBonificacao>();
            //var idade3;

            //var é inferencia do nome de tipo de cariavel
            var idade4 = 14;
            var nome = "Alura";
            string nome3 = "Alura";
            var resultado5 = SomarVarios(1, 5, 9);
            object conta4 = new ContaCorrente(344, 56456556);//mais comum 
            var conta5 = new ContaCorrente(344, 56456556);//mais comum 
            var gerenciador5 = new GerenciadorBonificacao();
            var gerenciadores5 = new List<GerenciadorBonificacao>();
            //conta4.Depositar(5222);//não pode
            conta5.Depositar(5222);
            //Ele pega o tipo da classe e coloca no lugar do VAR



        }
        static void TestaListaGenerica()
        {


            //Lista<int> idades = new Lista<int>();

            //idades.Adicionar(1);
            //idades.Adicionar(5);
            //idades.Adicionar(14);
            //idades.Adicionar(25);
            //idades.Adicionar(38);
            //idades.Adicionar(61);
            //idades.Remover(5);

            //for (int i = 0; i < idades.Tamanho; i++)
            //{
            //    Console.WriteLine(idades[i]);
            //}

            Lista<int> idades = new Lista<int>();//DEFINIR O TIPO DO ARRAY

            //idades.Adicionar("texto qualquer");
            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);



            //Você pode apontar uma referencia para NULL mas um int, bool também não
            ContaCorrente conta = null;
            Cliente cliente = null;
            Designer designer = null;
            //int idadeSoma = null;//Apresenta erro 
            //bool verdadeiroOuFalso = null;//Apresenta erro //padrão do bool é sempre falso
            string teste = null;
            int idadeSoma = 0;

            int[] arrayDeInt = new int[5];
            //arrayDeInt[0] = null;//também nao da por um array de inteiro


            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];// NÃO FOI NECESSÁRIO FAZER A CONVERSAO DE OBJECT PARA INT 
            }


            //Lista<string> idades2 = new Lista<string>();//DEFINIR O TIPO DO ARRAY
            //idades2.Adicionar("texto qualquer");
            //idades2.Adicionar(5);




        }
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);
            listaDeIdades.Adicionar("um texto qualquer");//nao pode

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDoGui = new ContaCorrente(111111, 11111111);

            //lista.Adicionar(new ContaCorrente(874, 5679787));
            //lista.Adicionar(contaDoGui);
            //lista.Adicionar(new ContaCorrente(874, 5679754));
            //lista.Adicionar(new ContaCorrente(874, 5679745));
            //lista.Adicionar(new ContaCorrente(874, 5679745));
            //lista.Adicionar(new ContaCorrente(874, 5679745));
            //lista.Adicionar(new ContaCorrente(874, 5679745));

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };
            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754));


            //lista.EscreverListaNaTela();

            //lista.Remover(contaDoGui);
            //Console.WriteLine("Apos remover o item");
            //lista.EscreverListaNaTela();

            //lista.MeuMetodo(numero: 10);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                //ContaCorrente itemAtual = lista.GetItemNoIndice(i);

                //ContaCorrente teste = lista["texto"];

                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }


        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaArraydeContaCorrente()
        {
            //ContaCorrente[] contas = new ContaCorrente[3];//Array de conta corrente com tamanho 3 
            //contas[0] = new ContaCorrente(874, 5679787);
            //contas[1] = new ContaCorrente(874, 4456668);
            //contas[2] = new ContaCorrente(874, 7781438);

            ContaCorrente[] contas = new ContaCorrente[]// Inicialização de arrays
           {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438),
                new ContaCorrente(874, 4242424)

           };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
                //Console.WriteLine($"Conta {indice} {contas[indice].Numero}"); //String Interpolation
            }


        }

        static void TestaArrayInt()
        {
            //Array de inteiros com 5 posições
            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 25;
            idades[2] = 35;
            idades[3] = 45;
            idades[4] = 55;
            //int indice = 4;
            //int idadenoIndice4 = idades[4];
            //int idadenoIndice4 = idades[2+2];
            //int idadenoIndice4 = idades[indice];
            //Console.WriteLine(idadenoIndice4);

            //int[] outroArray = idades;
            //Console.WriteLine(outroArray[3]);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");


            //bool[] arrayDeBooleanos = new bool[10];
            //arrayDeBooleanos[0] = true;
            //arrayDeBooleanos[1] = false;
            //arrayDeBooleanos[2] = false;




        }

        public static void UsoObjectEToString()
        {

            // Uso de object e To String
            object conta = new ContaCorrente(456, 687876); //Toda classe deriva da classe object
            object desenvolvedor = new Desenvolvedor("4564654");

            string contaToString = conta.ToString();

            Console.WriteLine(conta);
            Console.WriteLine(contaToString);


            //Console.WriteLine("Olá, mundo!");
            //Console.WriteLine(123);
            //Console.WriteLine(10.5);
            //Console.WriteLine(true);

            // "Olá, mundo!" é uma string
            // WriteLine é um método público estático
            // Console é uma classe pública



        }
        public static void UsoEquals()
        {

            //Uso do Equals
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(456, 87654);
            object conta = new ContaCorrente(235, 23462);

            Console.WriteLine(conta.Equals(123));
            //Console.WriteLine(conta.Numero);//Não pode acessar com o object
            Console.WriteLine(conta_2.Numero);


            if (carlos_1.Equals(carlos_2))//conta_2 //pode comparar agora com conta que vai dar false
            //    if (carlos_1 == carlos_2)
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }


        }
        public static void AnaliseRegex()
        {


            //string padrao = "Sala [A-G][-]?[0123456789]{2}";

            //Console.WriteLine(Regex.IsMatch("Sala G345", padrao));
            //Console.WriteLine(Regex.IsMatch("Sala J-001", padrao));
            //Console.WriteLine(Regex.IsMatch("Sala a004", padrao));
            //Console.WriteLine(Regex.IsMatch("Sala C004", padrao));
            //Console.WriteLine(Regex.IsMatch("Minha sala é a sala G34", padrao));
            //Console.WriteLine(Regex.IsMatch("Minha sala é a Sala G-34", padrao));



            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";//? é o {0,1}


            string textoDeTeste = "Meu nome é Guilherme, me ligue em 7844-4546";//Pode por o traço ou não
            Match resultado = Regex.Match(textoDeTeste, padrao);

            ////Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); //Verifica se existe e retona boolean
            Console.WriteLine(resultado.Value); //Retorna o valor que atende o padrão

        }
        public static void AnaliseURL()
        {
            //Argumentos
            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            //int indiceInterrogacao = url.IndexOf('?');
            //Console.WriteLine(indiceInterrogacao);

            //url += "sufixo";
            //Console.WriteLine(url);

            //string argumentos = url.Substring(indiceInterrogacao+1);
            //Console.WriteLine(argumentos);

            //string textoVazio = "";
            //Console.WriteLine(string.IsNullOrEmpty(textoVazio));

            //string palavra = "moedaOrigem=real&moedaDestino=dolar";
            //string nomeArgumento = "moedaDestino=";
            //int indice = palavra.IndexOf("moedaDestino");
            //Console.WriteLine(indice);

            //Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
            //Console.WriteLine(palavra.Substring(indice));
            //Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));//=dolar colocar + 1

            //Testando remoçao 
            //string testeRemocao = "primeiraParte&parteParRemover";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            //Teste de string que não existe
            //string teste2 = "sdfgsjdkf";
            //Console.WriteLine(teste2.IndexOf('1'));
            //Console.ReadLine();

            //Uso do Replace
            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //termoBusca = termoBusca.Replace('r', 'R');
            //Console.WriteLine(termoBusca);

            //termoBusca = termoBusca.Replace('a', 'A');
            //Console.WriteLine(termoBusca);

            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));


            //ToUpper -ToLower
            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //Console.WriteLine(termoBusca.ToUpper());
            //Console.WriteLine(mensagemOrigem.ToLower());

            //StartsWith - EndsWith
            //string urlTeste = "https://www.bytebank.com/cambio";
            //int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            ////Console.WriteLine(indiceByteBank == 0); //Removido para usar o StartsWith - EndsWith
            //Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            //Console.WriteLine(urlTeste.EndsWith("cambio"));
            ////Contains
            //Console.WriteLine(urlTeste.Contains("bytebank"));
            //Analise de ToUpper() e Replace()
            //string endereco = "R. São Carlos do Pinhal nº746";
            //string enderecoFormatado =
            //    endereco
            //        .ToUpper()
            //        //.Replace("r.", "Rua") //Ignora pq nao acha o "r."
            //        .Replace(" nº", ", Número ")//Ignora pq nao acha o" nº".
            //        .ToUpper();

            //Console.WriteLine(enderecoFormatado);

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

        }
        public static void VerificaVencimento()
        {
            DateTime dataFimPagamento = new DateTime(2020, 09, 9);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            //string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);
            // Console.WriteLine("Diferença em: " + mensagem);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine("Humanizer:  " + mensagem);

            Console.WriteLine("Diferença em: " + diferenca);
            Console.WriteLine(dataCorrente.Year);

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);
            Console.ReadLine();
        }
        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {

            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;

                if (quantidadeMeses == 1)
                {
                    return "1 mês";
                }
                else
                {

                    return quantidadeMeses + " meses";
                }
            }
            else if (timeSpan.Days > 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;
            }



            return timeSpan.Days + " dias";
        }

    }
}
