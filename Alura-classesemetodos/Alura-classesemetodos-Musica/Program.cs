Banda skank = new Banda("Skank");

Album albumSkank = new Album("Calango");

Musica musica1 = new Musica(skank, "Jackie Tequila")
{
    Duracao = 250,
    DisponivelPlano = true,

};
Musica musica2 = new Musica(skank, "Te ver")
{
    Duracao = 277,
    DisponivelPlano = false,
};

albumSkank.AdicionarMusica(musica1);
albumSkank.AdicionarMusica(musica2);
skank.AdicionarAlbum(albumSkank);

musica1.ExibirInformacoes();
musica2.ExibirInformacoes();

albumSkank.ExibirMusicas();
skank.ExibirAlbuns();