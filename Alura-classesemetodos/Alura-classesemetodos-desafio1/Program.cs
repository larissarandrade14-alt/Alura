Musica musica1 = new Musica();// Criação da primeira música (objeto)
musica1.Nome = "Vamos Fugir";
musica1.Artista = "Skank";
musica1.Duracao = 210;
musica1.DisponivelPlano = true;

Musica musica2 = new Musica();
musica2.Nome = "Sutilmente";
musica2.Artista = "Skank";
musica2.Duracao =  240 ;
musica2.DisponivelPlano = false;

musica1.ExibirInformacoes();// Exibe as informações da primeira música
Console.WriteLine(musica1.DescricaoResumida);

musica2.ExibirInformacoes();
Console.WriteLine(musica2.DescricaoResumida); // Acessa a propriedade de descrição resumida da segunda música

