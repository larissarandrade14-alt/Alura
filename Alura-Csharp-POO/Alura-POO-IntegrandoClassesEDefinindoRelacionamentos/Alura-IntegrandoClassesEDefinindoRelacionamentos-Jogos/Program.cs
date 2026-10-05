CatalogoJogos cj = new CatalogoJogos();
Jogos jogo1 = new Jogos("The Legend of Zelda: Breath of the Wild", 1, "Médio");
Jogos jogo2 = new Jogos("Among Us", 4, "Fácil");
Jogos jogo3 = new Jogos("Dark Souls III", 1, "Difícil");

cj.AdicionarJogo(jogo1);
cj.AdicionarJogo(jogo2);
cj.AdicionarJogo(jogo3);

cj.ExibirCatalogo();