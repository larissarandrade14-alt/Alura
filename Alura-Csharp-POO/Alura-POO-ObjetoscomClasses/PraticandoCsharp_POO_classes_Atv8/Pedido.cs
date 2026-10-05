    class Pedido
    {
    public string NomeCliente { get; set; }
    public string NumeroPedido { get; set; }
    public string Status { get; set; }
    public Pedido (string nomeCliente)
    {
        NomeCliente = nomeCliente;
    }
    public string AtualizarStatus(string novoStatus)
    {
        return Status = novoStatus; 
    }
    public void ExibirPedido()
    {
        Console.WriteLine($"\nPedido nº {NumeroPedido} \nNome do Cliente: {NomeCliente}  \nStatus do Pedido: {Status}");
    }
    }

