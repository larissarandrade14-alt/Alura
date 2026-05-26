class Produto
{
    public string Nome { get; set; }

    private double _preco;
    public double Preco
    {
        get => _preco;
        set
        {
            if (_preco > 0)
            {
                _preco = value;
            }
            else
            {
                Console.WriteLine("O preço deve ser maior que zero.");
            }
        }
    }

    public string Marca { get; set; }

    private int _estoque;
    public int Estoque {
        get => _estoque;
        set
        {
            if (value < 0)
            {
               _estoque = 0;
            }
            _estoque = value;
        }
    }
    public string Descricao => $"Produto: {Nome}, Preço: {Preco}, Marca: {Marca}, Quantidade em Estoque: {Estoque}";

}