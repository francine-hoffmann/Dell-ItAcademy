//array 
//basta adicionar colchetes , apos a declaração do tipo
//int[]meuarray
//instanciando array pode ser com new - int [] codigos = new int[5];
//ou na definaçãod e array mesmo, que serve geralmente para arrays pequenos - int[] pedidos = {1,2,3,4,5,6};
// numero de elementos dentro do array é o tamanhoi dele
// nome [0] = {"José"} posição definida dentro
int [] array = new int [5] {10, 20, 30, 40, 50};
for (int i=0; i<array.Length; i++)
//laço de repetição para alguma coisa , for sempre vai executar se fizer as condiçoes certas
{
    Console.WriteLine($"Indice = {i} Valor = {array[i]}");

}
var j = 0;
while (j<array.Length)
// laço de repetição enquanto a condição for verdadeira, while pode não executar , pq depende de condição externa
//procurar alguma coisa, ate que minha condiçãos eja verdadeira
{
    Console.WriteLine($"Indice = {j} Valor = {array[j]}");
    j++;
}
foreach (var item in array)
// para cada item , array dentro de uma coleção, so funciona em cima de coleção
{
    Console.WriteLine(item);

}
string [] palavras = new string [3];
Console.WriteLine(palavras[0]);
palavras [0] = "Um";
palavras [1] = "Dois";
palavras [2] = "Três";
Console.WriteLine(palavras.Length);
//tamanho do array
Console.WriteLine(palavras.Rank);
// tamanho da dimensão , no caso 1 pois esse array é unidimensional
// array multidimensional
//int[,] codigos = new int[2,2];
//tamanho de um matriz 2x2
//codigos [0,0] =11;
Console.WriteLine("Modelo de matriz");
int [,] matriz = new int [2,2];
matriz [0,0] = 1;
matriz [1,1] = 1;
foreach (var item in matriz)
//para cada dimensão da minha maatriz , indexar os valores nas posições
//vai indexar todos os itens da matriz
//pode não ter garantia de ordem
{
    Console.WriteLine(item);
}
    Console.WriteLine(matriz.Rank);
    Console.WriteLine(matriz.Length);

//retorno 1001
//retorno 2
//retorno 4

//ARAAY QUE CONTEM ARRAY - JAGGED
Console.WriteLine("Exemplo de array jagged");
int[] [] jagged = new int [2] [];
jagged [0] = new int [3] {1,2,3};
jagged [1] = new int [2];
Console.WriteLine(jagged.Rank);
Console.WriteLine(jagged.Length);
Console.WriteLine(jagged[0].Rank);
Console.WriteLine(jagged[0].Length);
Console.WriteLine(jagged[1].Rank);
Console.WriteLine(jagged[1].Length);
foreach (var subarray in jagged)
// subarray aqui não é um inteiro é um array de inteiros, pode ser nulo
{
    foreach (var item in subarray)
    //aqui o item sewra inteiro
    {
        Console.WriteLine(item);
    }
}




