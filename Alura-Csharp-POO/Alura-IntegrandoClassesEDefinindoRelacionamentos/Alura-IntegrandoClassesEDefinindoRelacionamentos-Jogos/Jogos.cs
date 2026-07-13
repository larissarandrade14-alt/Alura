//Desenvolver uma classe que representa um catálogo de jogos, com uma lista de
//Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.
public class Jogos
{
    public Jogos(string nome, int quantidadeJogadores, string dificuldade)
    {
        Nome = nome;
        QuantidadeJogadores = quantidadeJogadores;
        Dificuldade = dificuldade;
    }

    public string Nome { get; }
    public int QuantidadeJogadores { get; }
    public string Dificuldade { get; }
    public string Informacoes => $"{Nome} - {QuantidadeJogadores} jogadores - Dificuldade: {Dificuldade}"; 
}
public class CatalogoJogos
{
    public List<Jogos> CatalogodeJogos = new List<Jogos>();
    public void AdicionarJogo(Jogos jogo)
    {
        CatalogodeJogos.Add(jogo);
    }
    public void ExibirCatalogo()
    {
        Console.WriteLine("====== CATÁLOGO DE JOGOS ======\n");
        if (!CatalogodeJogos.Any())
        {
            Console.WriteLine("Nenhum jogo cadastrado.");
            return;
        }

        foreach (var jogo in CatalogodeJogos)
        {
            Console.WriteLine(jogo.Informacoes);
        }

    }
}