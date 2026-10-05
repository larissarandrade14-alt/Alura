    public class Banda
    {
    {
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
       albuns.Add(album);
    }
    public void ExibirAlbuns()
    {
        Console.WriteLine($"\nÁlbuns da banda {Nome}:\n");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} segundos) ");
        }
    }
}

