// isto não é possível
//int x = null;
//isso é possivel, colocando o interrogação ao lado , estou dizendo que meu objeto pode ser anulavel( int? string?)
//novos operadores null-forgiving
int? y = null;
Console.WriteLine(y);
string s = null;
Console.WriteLine(s);
string? t = null;
Console.WriteLine(t);
// qual valor das variaveis nas seguintes declarações?
//string first; (valor default = null)
//string second = string.Empty; ( aqui foi inicializada explicitamente, nunca será null)
//int third; (valor default de int = 0 )
//DateTime date; (valor default de datetime = 00/00/00 Minvalue)
//int? first; (aqui o valor sera null)
//int? second = null; (aqui null)
//int? third = default; (aqui null)
//int? fourth = new(); (aqui 0)
//Sempre inicializar quando colcoar uma variavel, pois tem essas particularidades e o programador que vier depois para fazer a manutenção pode não saber e criar um bug
//string first = string.Empty; ( se foi inicializada o compialdor nunca entendera que é null ,. nunca será null)
//string second;  ( valor default de um tipo referencia é um valor null, mas recebera um warning para alertar que esqueceu de inicializar, inicialmente será null )
//string? third; ( aqui pode ser null)
int? a = 28;
int b = a ?? 0;
Console.WriteLine(b);
// operador null Coalesing ?? b sera 28 pois a foi inicializado com 28
// operador null forgiving ! apos a inicialização é null o valor e vou usar
int? c = null;
int d = c ?? 0;
Console.WriteLine(d);
// nesse null coalesing será 0 , pois c é null então pegará o 0 c??0 significa pegue o valor de c  ou 0, como c é null ele assume o valor 0 da expressão
int? e = a + c;
Console.WriteLine(e);
// qualquer valor somado com null vira null
string st = null!;
Console.WriteLine(st);
// exclamação ali null forgiving, esta dizendo que aquela expressão pode ser nula
DateTime? dt = DateTime.Now;
Console.WriteLine(dt?.Day);
// null condicional, se não colocar o interrogação no dt?.day ele não deixa pois day não aceita o datetime?, porem usando null condicional ele vai pois ele diz "compilador se dt for diferente de null , pegue o day se ela for null o valor da expressão será null"
if (dt != null){
    Console.WriteLine(dt?.Day);
}
if (dt.HasValue){
    Console.WriteLine(dt.Value.Day);
    Console.WriteLine(dt.HasValue);
}
//todas as expressoes são a mesma coisa so de maneira diferente no terceiro exemplo o has value é um boleano, vai verificar se o valor de dt é null se for ele não realiza a segunda linha , se for ele printa










