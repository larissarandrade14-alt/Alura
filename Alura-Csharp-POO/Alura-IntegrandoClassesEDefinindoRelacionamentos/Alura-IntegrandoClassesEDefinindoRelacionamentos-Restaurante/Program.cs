Restaurante restaurante = new Restaurante();

restaurante.Mesas.Add(new Mesa()
{
    Numero = 1,
    Ocupada = true
});

restaurante.Mesas.Add(new Mesa()
{
    Numero = 2,
    Ocupada = false
});

restaurante.Mesas.Add(new Mesa()
{
    Numero = 3,
    Ocupada = true
});

Pedidos pedidos = new Pedidos();

pedidos.FazerPedido(restaurante);
