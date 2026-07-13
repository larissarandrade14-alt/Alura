//Banda skank = new Banda("Skank");
//Banda paralamas = new Banda("Paralamas do Sucesso");
//Album albumPDS = new Album("O Passo do Lui");
//Album albumPDS2 = new Album("Big Bang");
//Album albumSkank = new Album("Calango");

//Musica musica1 = new Musica(skank, "Jackie Tequila")
//{
//    Duracao = 250,
//    DisponivelPlano = true,

//};
//Musica musica2 = new Musica(skank, "Te ver")
//{
//    Duracao = 277,
//    DisponivelPlano = false,
//};
//Musica musica3 = new Musica (paralamas, "Lanterna dos Afogados")
//{
//    Duracao = 266,
//    DisponivelPlano = false,
//};

//Playlist rock = new Playlist("Rock Nacional");
//rock.AdicionarMusicaPlaylist(musica3);
//rock.AdicionarMusicaPlaylist(musica1);
//rock.ExibirMusicas();

//albumSkank.AdicionarMusica(musica1);
//albumSkank.AdicionarMusica(musica2);
//albumPDS.AdicionarMusica(musica3);
//skank.AdicionarAlbum(albumSkank);

//musica1.ExibirInformacoes();
//musica2.ExibirInformacoes();

//albumSkank.ExibirMusicas();
//skank.ExibirAlbuns();

Episodio ep1 = new Episodio ("Boas práticas", 120, 2);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");

Episodio ep2 = new Episodio("Aprendizados", 120, 1);
ep2.AdicionarConvidados("Larissa");
ep2.AdicionarConvidados("José");


Podcast pod = new("Ensinamentos", "André Augusto");
pod.AdicionarEpisodio(ep2);
pod.AdicionarEpisodio(ep1);
pod.ExibirInformacoes();