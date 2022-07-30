byte b;
b = byte.MaxValue;
Console.WriteLine("Valor máximo de byte:" + b);
Console.WriteLine($"Valor máximo de bytes: {b}");
long l;
l = long.MaxValue;
Console.WriteLine("Valor máximo de long:" + l);
int i;
i = int.MaxValue;
Console.WriteLine("Valor máximo de int:" + i);

string strPrimeira = "Alô";
string strSegunda = "Mundo";
string strTerceira = strPrimeira +strSegunda;
Console.WriteLine(strTerceira);
/* ToString converte para string*/
int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);
/* Datetime é uma structy ou seja é um tipo valor diferente de Java, tem metodos, valores igual uma class --- dt . aparece valios operadores, isso significa que ocorre sobrecarga de operadores */
DateTime dt = new DateTime(2022,7,19);
Console.WriteLine(dt.ToShortDateString());
DateTime agora = DateTime.Now;
Console.WriteLine(agora);

int a = 10;
float f = 0;
f = a;
Console.WriteLine(f);
/* valor inteiro é menor que o tipo flutuante ou seja essa conversão implicita ocorre sem perda de dados 
já no exemplo abaixo a conversão direta ele não faz pois o float é menor que o int tendo perda de dados no processo tem que usar o int (operador de cast que é um operador explicito) na frente pra ele fazer a conversão e perder os dados no processo se der um run o numero ira aparecer no console apenas o 0
  / 0.5 é um tipo double ai não pode sem usar o f depopis do numero pois float é menor que double*/
f = 0.5f;
i = (int)f;
Console.WriteLine(i);









