ClienteSimples c = new ClienteSimples ("Jaime Fraser", new DateTime(2022, 7, 20));
PedidoSimples p1 = new PedidoSimples (new DateTime(2022, 6, 20), 110.55m);
c.AdiconarPedido(p1);
PedidoSimples p2 = new PedidoSimples (new DateTime (2022, 7, 22), 1.99m);
c.AdiconarPedido(p2);
Console.WriteLine(c.Nome);
Console.WriteLine(c.DataCriacao);
Console.WriteLine(c.PedidoAnteriores);
Console.WriteLine(c.UltimaCompra);
foreach (var pedido in c.PedidoAnteriores)
{
    Console.WriteLine(pedido);
}
