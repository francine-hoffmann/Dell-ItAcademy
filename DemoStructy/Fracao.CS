public readonly struct Fracao
//por ter um readonly aqui significa que os mebros desta fracao são imutaveis, somente de leitura
// objeto como outro qualquer, tem campo, metodos, construtor, porem não se pode usar herança
{
    private readonly int num;
    private readonly int den;

    public Fracao (int numerador, int denominador)
    {//assumir que o denominador != 0
        num = numerador;
        den = denominador;

    }
    public int Numerador => num;
    public int Denominador => den;
    public string FracaoPorExtenso() => $"{num}/{den}";
    public static Fracao operator * (Fracao a, Fracao b)
    //sobrecarga de operador
    {
        return new Fracao(a.num * b.num, a.den * b.den);
    }

}