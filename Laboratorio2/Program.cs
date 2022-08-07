//quando você faz uma variavel var , tem que iniciar a mesma - tipo implicito ( a inicialização é necessaria para que o compilador saiba do que se trata) 
//(int,int)par = (1,2);      (int,char) par = (1, 2) - tuplas matematicas
//(int , char ) par = (1, '2');
//Console.WriteLine(par.Item1);
// Item1 representa o int , o char seria item2, são autogerados pelo compilador

//Classes
//tipos referência
//propriedades e comportamentos semelhantes
//relacionamentos comuns com outros objetos

//membros das classes
// -constantes,campos, metodos, propriedades, indexadores, eventos, operadores, construtores, finalizadores
//tipos aninhados
//membros "de instância" e de "classe"

//MODIFICADORES DE ACESSO
//public - acesso ilimitado
//private - acesso limitado á classe e seus membros
//internal - acesso limitado ao codigo no mesmoa ssembly(exe ou dll)
//protected - acesso limitado a classe, seus mebros e derivados da mesma
//protected internal - acesso limitado a classe, classes derivadas ou classes do mesmo assembly
//private protected - acesso limitado a classe, classes derivadas no mesmo assembly
    Correntista c1 = new Correntista {Nome="John Doe", Cpf = "123456789"};
    Console.WriteLine(c1.Nome);
    Console.WriteLine(c1.Cpf);
    ContaCorrente conta1 = new ContaCorrente(0, c1);
    ContaCorrente conta2 = new ContaCorrente(1, c1);

    // instânciamos o objeto  - class - valor default null
    // construtor default 
    conta1.Depositar(100);
    conta1.Sacar(50);
    Console.WriteLine(conta1.Saldo);
    // metodos equals, tostring, gettype, gethascode foram herdados com a classe., porque em c# tudo é um object
    Console.WriteLine(conta1.DataCriação.ToShortDateString());
    Console.WriteLine(DateTime.MinValue);

    ContaCorrente conta3 = new ContaCorrente ("Mary Poppins", "134567892");

    conta3.Depositar(1500);
    conta3.SalvarSaldo();
    conta3.Sacar(135);
    conta3.SalvarSaldo();
    conta3.Depositar(356);
    conta3.SalvarSaldo();
    conta3.SaldoMedio();
    conta3.SaldoMedioDeposito();



    //Correntista c1 = new Correntista ();
    //Console.WriteLine(c1.Nome);
    //CPF NECESSITA DE UMA PROPRIEDADE DE INICIALIZAÇÃO






