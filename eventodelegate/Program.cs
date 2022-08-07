//passo1 declarar um delegate
//public delegate void FazAlgoDelegate(intx);
//passo 2 declarar evento (deve ser do mesmo tipo do delegate)
//public event FazAlgoDelegate UmEvento;
//vão ser eventos publicos na maioria da vezes
//passo 3 disparar o evento na chamada de algum metodo da classe
//public void metodoEvento(int x)
//    { if (UmEvento!= null) UmEvento (x);}
//passo 4 assinar o evento indicando o manipulador de eventos do mesmo atravez de uma instancia de delegate
//UmaClasse obj = new UmaClasse();
//obj.UmEvento += new FazAlgoDelegate (ManipuladorEvento);
static void TratadorDaExplosão(object? sender, EventArgs e)
{
    Console.WriteLine("A bomba explodiu");
}
//void pq nosso metodo da bomba é void com 2 parametros
Bomba b = new Bomba(3);
b.FezBum += TratadorDaExplosão;
// qd a bomba explodir vai executar o tratador de explosao, o evento é a explosão e os tratadores são ativados com o evento , podem ter varios
// criando a bomba com 3 tics
// passar os 3 tics ela explode
//fezbum , aparece como um raiozinho, ele é o evento
// associar click de botão um evento é um exemplo
b.Tic();
Console.WriteLine("tic");
b.Tic();
Console.WriteLine("tic");
b.Tic();
Console.WriteLine("tic");
b.Tic();//aqui vai explodir
Console.WriteLine("tic");
//meu programa nuca chamou o metodo tratador , quem chamou foi a bomba, a bomba como ja foi visto é o evento


