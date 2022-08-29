public class CirculoColorido : Circulo
//herdando as coisas de circulo
{
    private string minhaCor;
    public string Cor
    {
        get {return minhaCor;}
        set {minhaCor = value;}
    }
    public CirculoColorido()
    {
        minhaCor = "preto";
        //esse construtor ainda esta chamando o construtor herdado 
    }
    public CirculoColorido(double x, double y, double r, string c)
    :base (x,y,r)
    {
        minhaCor = c;
    }
    public override string ToString()
    {
        return base.ToString() + $" cor={Cor}";
    }
    public new string ToStringHashCode()
    // se não colocar new , ele da um warning te lembrando que esse metodo esta ocultando um metodo herdado 
    {
       return  "uma coisa qualquer"; 
    }
}

//todo construtor chama o construtor da classe herdada
