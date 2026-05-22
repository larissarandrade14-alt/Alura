class Musica
{
    // Atributos da classe Musica
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivelPlano;

    public void ExibirInformacoes() // Método para exibir as informações da música
    {
        Console.WriteLine($"Nome da música: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao} segundos");
        if (disponivelPlano)
        {
            Console.WriteLine("Disponível para plano gratuito");
        }
        else
        {
            Console.WriteLine("Disponível apenas para plano pago");
        }
    }

}

