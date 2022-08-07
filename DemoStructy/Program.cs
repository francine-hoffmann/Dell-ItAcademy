Fracao f1 = new Fracao(1,2);
Fracao f2 = new Fracao(3,4);
Console.WriteLine(f1.FracaoPorExtenso());
Console.WriteLine(f2.Numerador);
Fracao f3 = f1 * f2;
// isso não funcionaria se não fizesse a sobre carga do operador , pois o objeto não supporta essa multiplicação
Console.WriteLine(f3.FracaoPorExtenso());