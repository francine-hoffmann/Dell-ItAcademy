//EXERCICIO 1 
float f = float.MaxValue;
Console.WriteLine(f);

double numero = f;
Console.WriteLine(numero);

int number = (int)f;
Console.WriteLine(number);
// int não converte para float ai o numnero deu negativo , se perdeu

double d = 123.4;
Console.WriteLine(d);

decimal dec = decimal.MinValue;
Console.WriteLine(dec);

decimal deci = 4.5m;
Console.WriteLine(deci);

decimal decim = new decimal(4.5);
Console.WriteLine(decim);

float fi = 3_000.5f;
Console.WriteLine(fi);
// exercicio 2
string a = "criando uma string simples";
Console.WriteLine(a);
// criando uma instancia de string simples

string b = " concatenando string com " + DateTime.Now.ToShortDateString();
Console.WriteLine(b);

string c = b + " nesta data estou aprendendo C#";
Console.WriteLine(c);

string e = "Elias é um cuzão ";
string g = "sem pacinência ";
string h = "bora humilhar a esposa";
string j = e + g +h;
Console.WriteLine(j);

string extrair = " Se não vai me fazer desistir";
string ex;
ex = extrair.Substring(3,5);
Console.WriteLine(extrair);
Console.WriteLine(ex);

string value = "cu uva nata pipoca samambaia";
int starIndex = 0;
int lenght = 2;
string cu = value.Substring(starIndex,lenght);
Console.WriteLine(cu);
starIndex = 3;
lenght = 3;
string uva = value.Substring(starIndex,lenght);
Console.WriteLine(uva);
starIndex = 7;
lenght = 4;
string nata = value.Substring(starIndex, lenght);
Console.WriteLine(nata);
starIndex = 12;
lenght = 6;
string pipoca = value.Substring(starIndex, lenght);
Console.WriteLine(pipoca);
starIndex = 19;
lenght = 9;
string samambaia = value.Substring(starIndex, lenght);
Console.WriteLine(samambaia);

// exercicio 3
var data = DateTime.Now;
Console.WriteLine(data);
var data2 = new DateTime(2022,08,20);
Console.WriteLine(data2);
Console.WriteLine(data2.Day);
Console.WriteLine(data2.DayOfWeek);
Console.WriteLine(data2.Month);
Console.WriteLine(data2.Year);
var data3 = DateTime.Now.ToShortDateString();
Console.WriteLine(data3);
var dataDefault = new DateTime();
Console.WriteLine(dataDefault);
DateTime? dataNull = DateTime.Now;
Console.WriteLine(dataNull?.Day);
DateTime min = DateTime.MinValue;
Console.WriteLine(min);
Console.WriteLine(min.Equals(DateTime.MinValue));

//exercicio 4

int inteiro = 28;
float fig = 3_009f;
fig = inteiro;
Console.WriteLine(inteiro);
Console.WriteLine(fig);
// conversão implicita - tipo menor ele vai de boas
int gh = 72;
float ghf = 3_456f;
gh = (int)ghf;
Console.WriteLine(gh);
Console.WriteLine(ghf);

// conversão explicita - tipo maior ele não faz de boas , perde dados.

// exercicio 5

string stringInteiro = "123456";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);

Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

string dezessete = "17";
int banana = Convert.ToInt32(dezessete);
Console.WriteLine(banana);

int vinte = 20;
string vinteString = Convert.ToString(vinte);
Console.WriteLine(vinteString);

//string inteiroGrande = "9999999999999999999999999999999999999999999999999999";
//int valorInteiroGrande = Convert.ToInt32(inteiroGrande);
//Console.WriteLine(valorInteiroGrande); da uma excessão pois o valor da string inicial é muito grande para o int32

//exercicio 6

string grande = "9999999999999999999999999999999999999999999";
int valorSuperGrande;
bool conversao = Int32.TryParse(grande, out valorSuperGrande);
Console.WriteLine("Conversão efetuada " + conversao + " Valor: " + valorSuperGrande);

string stringInteira = "123456789";
int valorStringInteira;
bool conversao1 = Int32.TryParse(stringInteira, out valorStringInteira);
Console.WriteLine("conversão efetuada " + conversao1 + " valor: " + valorStringInteira);

string stringLetras = "abc";
double valorStringLetras;
bool conversao2 = Double.TryParse(stringLetras, out valorStringLetras);
Console.WriteLine("conversão efetuada " + conversao1 + " valor: " + valorStringLetras);

// tryParse faz uma conversão segura, ( variavel, out variavel 2) se a conversão for bem sucedida ele retorna true e o valor da conversão se não for possivel ele retorna false e o valor da variavel int que no exemplo era default, ou seja, 0

//exercicio 7 

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);
Console.WriteLine(valorInteiro1);
Console.WriteLine(valorInteiro2);
//na primeira conversão por ser uma conversão explkicita se perdeu dados ou seja o 7 so caiu no limbo, na segunda conversão ele arredondou o valor 4,7 para 5

//exercicio 8

int x = 10;
double y = 3.4;
Console.WriteLine("{0} {1}" , x, y);
Console.WriteLine($"{x} {y}");
// no primeiro console as chaves dentro das aspas é como se fossem posições para as variaveis partindo do 0 , 1 , 2 etc apos as chaves colocamos entre virgulas as variaveis que queremos inserir naquelas posições.
// no segundo console é mais simples abre o dolar e coloca entre chaves as variaveis.






































