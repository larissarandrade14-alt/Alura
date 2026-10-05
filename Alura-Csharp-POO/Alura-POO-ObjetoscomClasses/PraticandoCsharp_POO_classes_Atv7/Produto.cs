
     class Produto
    {
    public string Nome { get; set; }
    public int QuantidadeEstoque { get; set; }
    public Produto (string nome, int estoque)
    {
        Nome = nome;
        QuantidadeEstoque = estoque;
    }
    public void Retirar(int quantidade)
    {
        if (quantidade > QuantidadeEstoque)
        {
            Console.WriteLine("\nA quantidade de retirada é maior que a quantidade no estoque");
        }
        else
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine($"\nA quantidade atual do estoque de {Nome} é {QuantidadeEstoque} unidades");
        }
    }
    }

