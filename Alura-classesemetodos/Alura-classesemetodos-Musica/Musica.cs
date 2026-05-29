class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    // Atributos da classe Musica
    public string Nome { get; }
    public DateTime DataLancamento { get; set; }
    public Banda Artista { get; set; }
    public Genero Genero { get; set; }

    public int Duracao { get; set; }
    public bool DisponivelPlano { get; set; } //Propriedade para indicar se a música está disponível 

    public string DescricaoResumida => $"A música '{Nome}' pertence ao artista {Artista}";

    public void ExibirInformacoes() // Método para exibir as informações da música
    {
        Console.WriteLine($"\nNome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (DisponivelPlano)
        {
            Console.WriteLine("Disponível para plano gratuito");
        }
        else
        {
            Console.WriteLine("Disponível apenas para plano pago");
        }
    }

}

