using ProjetoCarro.Models;
using ProjetoCarro.Services;

DescricaoCarro descricao = new DescricaoCarro();

Carro carro = DescricaoCarro.CriarCarro();

carro.ExibirInformacoes();

AcoesCarro acoes = new AcoesCarro();

acoes.Executar(carro);