//EXERCICIO 1
int [] arrayCem = new int [100]; 

Random r = new Random();
for (int i = 0; i < 100; i++) 
{ 
    arrayCem[i] = r.Next(); 
    Console.WriteLine(arrayCem[i]);
}
Console.WriteLine("Copia de arrayCem");
int[] cemVazio = new int [100];

arrayCem.CopyTo(cemVazio, 0);
foreach(var itens in cemVazio )
{
    Console.WriteLine(itens);
}
//FOI  UTILIZADO UM METODO O COPYTO COM UM LAÇO DE REPETIÇÃO
//EXERCICIO 2
Console.WriteLine("Exercicio 2");
int [,] matriz = new int [5,5];
matriz[0,0] = 1;
matriz[0,1] = 2;
matriz[0,2] = 1;
matriz[0,3] = 1;
matriz[0,4] = 4;
matriz[1,0] = 1;
matriz[1,2] = 1;
matriz[1,3] = 5;
matriz[1,4] = 1;
matriz[2,0] = 1;
matriz[2,1] = 1;
matriz[2,2] = 1;
matriz[2,3] = 7;
matriz[2,4] = 1;
matriz[3,0] = 1;
matriz[3,1] = 2;
matriz[3,2] = 1;
matriz[3,3] = 1;
matriz[3,4] = 1;
matriz[4,0] = 1;
matriz[4,1] = 1;
matriz[4,2] = 5;
matriz[4,3] = 1;
matriz[4,4] = 2;

for (int coluna = 0 ; coluna < matriz.GetLength(0); coluna++)
{
    int somaColuna = 0;
    for (int linha = 0 ; linha < matriz.GetLength(1); linha++)
    {
        
        somaColuna = somaColuna + matriz[coluna, linha];
    }

    Console.WriteLine(somaColuna);
}

// parte jagger
Console.WriteLine("Jagger");
int [] [] jagged = new int [5] [] ;
jagged[0] = new int [5] {1,2,3,4,5};
jagged[1] = new int [5] {1,3,7,2,6};
jagged[2] = new int [5] {2,4,1,5,8};
jagged[3] = new int [5] {4,1,1,3,9};
jagged[4] = new int [5] {3,5,1,1,3};

for (int linha = 0 ; linha< jagged.GetLength(0); linha++)
{   
    int somaColunaj = 0;
    for (int coluna = 0 ; coluna< jagged[linha].GetLength(0); coluna++)
    {   
        somaColunaj = somaColunaj + jagged[linha][coluna];
        
    }
    Console.WriteLine("Soma da coluna " + somaColunaj);
}







