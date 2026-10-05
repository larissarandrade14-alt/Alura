Pedido pedido = new Pedido("Larissa");
pedido.NumeroPedido = "001";
pedido.Status = "Pedido Aceito";
pedido.ExibirPedido();
pedido.AtualizarStatus("Em andamento");
pedido.ExibirPedido();


Pedido pedido2 = new Pedido("André");
pedido2.NumeroPedido = "002";
pedido2.Status = "Pedido Aceito";
pedido2.ExibirPedido();
pedido2.AtualizarStatus("Em andamento");
pedido2.ExibirPedido();
