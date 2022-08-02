public class ContaCorrente
{
    private Correntista correntista;
    private decimal saldo;
    public decimal Saldo
    {
        get{ return saldo;}
        //public decimal Saldo => saldo; 
        // ela somente vai retornar o valor de saldo (leitura)
    }
    public DateTime DataCriação { get; }
    public Correntista Correntista => correntista;
    // está utilizando o valor default de decimal 0,0
    // privado para que ninguem possa ver fica exclusivo da classe
    // implementar uma propriedade de leitura para o saldo. Saldo com maiuscula é a propriedade prop de leitura get e o set é de leitura
    public void Depositar (decimal valor)
    {
        saldo = saldo + valor;
        //saldo += valor; mesma coisa da linha de cima
    }
    public void Sacar ( decimal valor)
    {
        saldo = saldo - valor;
        //objetos podem ter propriedades podem ser de leitura ou escrita
        //se o dado que vamos expor é somnente de escrita , a propriedade sera de escrita se ela for de leitura a prop será de leitura e por assim vai

    }
        //construtor proprio tem o nome da classe
    public ContaCorrente (decimal valor, Correntista umCorrentista)
    {
        saldo = valor;
        // pode se usar this.saldo para retirar conflito de nome se caso o parametro valor fosse saldo.
        DataCriação = DateTime.Now;
        correntista = umCorrentista;
        //pode ser inicializada aqui no construtor, depois de inicializada não pode ser alterada pois é uma prop de leitura
    }
    public ContaCorrente (string nomeCorrentista, string cpfCorrentista)
    :this(0,new Correntista {Nome=nomeCorrentista,Cpf=cpfCorrentista})
    // o this esta trazendo o construtor de cima , para não repetir o codigo

    {
        
    }

}