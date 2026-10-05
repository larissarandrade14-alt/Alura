//Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
Estoque produtos = new Estoque();   
Produto xampu = new Produto()
{
    Id = 1,
    Nome = "Xampu",
    Quantidade = 10,
    Preco = 15.50,
    Marca = "Marca X"
};
Produto condicionador = new Produto()
{
    Id = 2,
    Nome = "Condicionador",
    Quantidade = 5,
    Preco = 20.00,
    Marca = "Marca Y"
};

produtos.AdicionarProduto(xampu);
produtos.AdicionarProduto(condicionador);


Produto sabonete = new Produto()
{
    Id = 3,
    Nome = "Sabonete",
    Quantidade = 20,
    Preco = 5.00,
    Marca = "Marca Z"
};

produtos.AdicionarProduto(sabonete);

Produto escova = new Produto()
{
    Id = 4,
    Nome = "Escova de Dente",
    Quantidade = 15,
    Preco = 8.00,
    Marca = "Marca W"
};
produtos.AdicionarProduto(escova);
produtos.RemoverProduto(xampu);

Console.WriteLine("Digite o produto que você procura: ");
string produtoProcurado = Console.ReadLine();
if (produtoProcurado != null)
{
    var produtoEncontrado = produtos.Produtos.FirstOrDefault(p => p.Nome.Equals(produtoProcurado, StringComparison.OrdinalIgnoreCase));
    if (produtoEncontrado != null)
    {
        Console.WriteLine("Produto encontrado:");
        produtoEncontrado.ExibirInformacoes();
    }
    else
    {
        Console.WriteLine("Produto não encontrado no estoque.");
    }
}
