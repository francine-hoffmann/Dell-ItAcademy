public interface ICliente
{
    string Nome {get;}
    DateTime? UltimaCompra {get;}
    DateTime DataCriacao {get;}
    IEnumerable<IPedido> PedidoAnteriores {get;}
    private static decimal desconto = 0.10m;
    private static int quantidade = 5;
    private static TimeSpan periodo = new TimeSpan(365,0,0,0);
    // periodo de tempo timespan 
    // esses tres valores se referem a 10% de desconto se a pessoa comprar 5 x em um ano
    private static void AlterarValoresPadrão( TimeSpan p, int q, decimal d)
    {
        periodo = p;
        quantidade = q;
        desconto= d;
    }
    protected static decimal CalcularDescontoPadrao(ICliente cliente)
    {
        DateTime inicio = DateTime.Now - periodo;
        if (cliente.DataCriacao < inicio && cliente.PedidoAnteriores.Count() >= quantidade )
        {
            return desconto;
        }
        return 0;
    }
    public decimal CalculaDesconto() => CalcularDescontoPadrao(this);
}
    //implementação padrão de membros de instância

