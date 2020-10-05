//Main antigo
//    static void Main(string[] args)
//{
//    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

//    Funcionario carlos = new Funcionario(2000, "546.879.157-20");
//    carlos.Nome = "Carlos";


//    carlos.AumentarSalario();
//    Console.WriteLine("Novo Salário Carlos: " + carlos.Salario);

//    gerenciador.Registrar(carlos);
//    Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//    Diretor roberta = new Diretor("454.658.148-3");
//    roberta.Nome = "Roberta";
//    //roberta.CPF = "454.658.148-3";
//    // roberta.Salario = 5000;

//    gerenciador.Registrar(roberta);
//    Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
//    Console.WriteLine("Total de diretor: " + Diretor.TotalDeDiretor);

//    Funcionario robertateste = roberta;
//    roberta.AumentarSalario();
//    Console.WriteLine("Novo Salário Carlos: " + roberta.Salario);

//    //Funcionario pedro = new Diretor(); //Tambem pode ser assim 


//    Console.WriteLine("Carlos: " + carlos.Salario);
//    Console.WriteLine("Carlos bonificação: " + carlos.GetBonificacao());
//    Console.WriteLine("Roberta: " + roberta.Salario);
//    Console.WriteLine("Roberta bonificação: " + roberta.GetBonificacao());
//    Console.WriteLine("Robertateste bonificação: " + robertateste.GetBonificacao());

//    Console.WriteLine("Total de bonificações:" + gerenciador.GetTotalBonificacao());

//    Console.Read();
//}
//    }