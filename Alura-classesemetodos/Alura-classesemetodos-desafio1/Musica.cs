class Musica
{
    // Atributos da classe Musica
    public string Nome { get; set; }
    public DateTime DataLancamento { get; set; }
    public string Artista { get; set; }

    public int Duracao { get; set; }
    public bool DisponivelPlano { get; set; } //Propriedade para indicar se a música está disponível 

    public string DescricaoResumida => $"A música '{Nome}' pertence ao artista {Artista}"; 
    
    public void ExibirInformacoes() // Método para exibir as informações da música
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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

