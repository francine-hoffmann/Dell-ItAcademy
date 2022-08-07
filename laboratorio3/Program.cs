List<string> listaString = new List<string>();
listaString.Add("Um");
listaString.Add("hello");
listaString.Add("Wolrd");
Console.WriteLine(listaString[0]);
// [] dentro do console é um this que esta indexando uma posição
// não tente indexar uma posição invalida, excessão
listaString[0] = "Alterado";
Console.WriteLine(listaString[0]);
Console.WriteLine(listaString.Count);
foreach (var item in listaString)
{
    Console.WriteLine(item);
}
//DELEGATE
//metodo forEach , posso chamar sobre uma lista, porem o parametro dele é um objeto do tipo action - esse action é um delegate
// passagem do metodo foreach é outro metodo delegate, não é class, nem structy é um delegate
//estrutura do delagte se parece coma  declaração de um metodo, ele retorna void e o parametro é um objeto do tipo t, somente um parametro de entrada.
// metodo de parametro de outro metodo - programnacao funcional
Console.WriteLine("Mesma forma de escrever que o foreach de cima , porem aqui é metodo");
listaString.ForEach(Console.WriteLine);
//mesma coisa que a linha 11, 12, 13 - porem em uma linha só
listaString.ForEach(item => Console.WriteLine(item.Length));
//metodo que foi defino agora, metodo que tem como parametro a variavel item , percorra a lista de string  e retorne o tamanho de cada item.
// fazemos tudo em uma linha só, programação funcional

//METODO FIND PARA LISTA 
//metodo que retorna um elemento que pode ser nulo de acordo com o objeto que é um predicate - predicate é um delegate
// predicate capaz de refenciar um metodo que retorna um boll , pode retornar outra coisa ? NÃO
// entra um objeto e ele retorna um booll
Console.WriteLine("metodo find e calculo lambda");
var elemento = listaString.Find(item => item[0] == 'H');
Console.WriteLine(elemento);

//calculo lambda nome disso
// primeiro item é o parametro de entrada , ele é uma string, pois a liosta é de strings e o corpo de definição é oque esta depois nda setinha, teste de igualdade, é um booleano 
// buscar na lista o primeiro elemento que começa com a letra h

//EVENTO
// ação que pode ser ggerenciada 
//manipulada atravez do codigo
//eventHandler eventArgs





