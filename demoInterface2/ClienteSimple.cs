using System.Collections.Immutable;
public class ClienteSimples : ICliente

{
    public string Nome { get; }

    public DateTime? UltimaCompra { get; private set; }

    public DateTime DataCriacao { get; }

    public IEnumerable<IPedido> PedidoAnteriores => todosPedidos.ToImmutableList();

    //copiar todos os itens da lista para uma lista que não pode ser alterada
    private List<IPedido> todosPedidos = new List<IPedido>();
    public ClienteSimples (string n, DateTime d)
    {
        Nome = n;
        DataCriacao = d;
    }
    public void AdiconarPedido (IPedido p)
    {
        todosPedidos.Add(p);
        if (p.DataCompra > (UltimaCompra ?? DateTime.MinValue))
        //se deixar apenas a data da aultima compra o codigo não vai funcionar pois a data da aultima compra pode ser null , ai temos  dizer se for null pegue o menor valor de data compra
        {
            UltimaCompra = p.DataCompra;
        }
    }
}