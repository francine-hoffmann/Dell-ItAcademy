public  class Circulo
// se tu colocar public class selaed - torna-se fechada ou seja não permite herança
{
    private double coordX;
    private double coordY;
    private double raio;
    public double CentroY
    {
        get {return coordY;}
        set {coordY = value;}
    }
    public double CentroX
    { 
        get{return coordX;}
        set{coordX = value;}
    }
    public double Raio
    {
        get {return raio;}
        set {raio = value;}
    }
    public Circulo(double x, double y, double r)
    {
        coordX = x;
        coordY = y;
        raio = r;
    }
    public Circulo()
    :this(0,0,1)
    {}
    // meu circulo ja herdou todos os medotos que o objeto tem
    public override string ToString()
    {
        return $"({CentroX:F2};{CentroY:F2}) raio ={Raio:F2}";
        //RETORNA O VALOR com duas casas decimais f2
    } 
    //overide da pra sobreescrever metodos virtual
    public string ToStringHashCode()
    {
        return $"{GetType().Name} hash={GetHashCode()}";
    }
    // aqui seria um metodo que não herda a classe , ele não tem virtual
    
}
// 