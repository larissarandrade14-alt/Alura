Album albumSkank = new Album();
albumSkank.Nome = "Calango";
Musica musica1 = new Musica();
musica1.Nome = "Jackie Tequila";
musica1.Duracao = 250;
Musica musica2 = new Musica();
musica2.Nome = "Te ver";
musica2.Duracao = 276;

albumSkank.AdicionarMusica(musica1);
albumSkank.AdicionarMusica(musica2);
albumSkank.ExibirMusicas();