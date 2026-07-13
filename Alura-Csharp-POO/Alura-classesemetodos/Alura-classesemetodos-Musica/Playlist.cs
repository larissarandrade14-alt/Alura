public class Playlist
{
    private List<Musica> musicas = new List<Musica>();
    public Playlist(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public void AdicionarMusicaPlaylist(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicas()
    {
        Console.WriteLine($"\nMúsicas da playlist {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome} - Artista: {musica.Artista.Nome}");
        }
        Console.WriteLine($"\nDuração total da playlist: {DuracaoTotal} segundos");
    }
}