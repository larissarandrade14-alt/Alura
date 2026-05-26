class Carro
{
    public string fabricante { get; set}

    public string modelo { get; set}
    public int Ano
    {
        get => ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido para o ano. O valor deve estar entre 1960 e 2023.");
            }
            else { ano = value; }
        }
    }
    public int quantidadePortas { get; set; }
 

    public void exibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {fabricante}, {modelo}, {quantidadePortas} portas, {ano}");
    }
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando...");
    }
    public void Frear()
    {
        Console.WriteLine("O carro está freando...");
    }
    public void Buzinar()
    {
        Console.WriteLine("BIBIBI");
    }
}