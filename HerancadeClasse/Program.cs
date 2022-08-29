//system.object é a classe mãe em c#
// virtual quer dizer que o metodo pode ser sobrescrito com polimorfismo p
// para sobresecrever usa-se override
// se não tiver virtual , não pode sobreescrever, podemos apenas esconder o metodo
Circulo circ1 = new Circulo();
Console.WriteLine(circ1);
//retorna o nome da classe
Circulo circ2 = new Circulo(2.4, 5, 3);
Console.WriteLine(circ2);

CirculoColorido circ3 = new CirculoColorido();
Console.WriteLine(circ3);
// herdou o construtor default de circulo, porem não herda a sobrescrita raio 1 x e y = 0
CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
Console.WriteLine(circ4);

LinkedList<Circulo> circulos = new LinkedList<Circulo>();
//lista encadeada. pode adicionar circulo colrido porque herda de circulo 
circulos.AddLast(circ1);
circulos.AddLast(circ2);
circulos.AddLast(circ3);
circulos.AddLast(circ4);
Console.WriteLine("foreach polimorfico");
foreach (var item in circulos)
{
    Console.WriteLine(item);
}
Console.WriteLine("foreach NÃO  polimorfico");
foreach (var item in circulos)
{
    Console.WriteLine(item.ToStringHashCode());
    // não imprime , pois a variavel item é circulo e não esta herdando
}
Console.WriteLine(circ4.ToStringHashCode());
Console.WriteLine(((Circulo)circ4).ToStringHashCode());

    // não imprime , pois a variavel item é circulo e não esta herdando

