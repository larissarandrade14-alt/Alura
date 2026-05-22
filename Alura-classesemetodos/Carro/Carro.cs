class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
 

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