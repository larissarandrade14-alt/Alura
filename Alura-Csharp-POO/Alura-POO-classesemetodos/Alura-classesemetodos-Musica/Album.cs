using System.Threading.Channels;

public class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }
    public void AdicionarGenero(Genero genero)
    {
        Console.WriteLine($"Gênero {genero.Nome} adicionado ao álbum {Nome}");
    }
    public void ExibirMusicas()
    {
        Console.WriteLine($"\nMúsicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nDuração total do álbum: {DuracaoTotal} segundos");
    }
   
}
