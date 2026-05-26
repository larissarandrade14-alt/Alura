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
                Console.WriteLine("O estoque não pode ser negativo.");
            }
            _estoque = value;
        }
    }


}