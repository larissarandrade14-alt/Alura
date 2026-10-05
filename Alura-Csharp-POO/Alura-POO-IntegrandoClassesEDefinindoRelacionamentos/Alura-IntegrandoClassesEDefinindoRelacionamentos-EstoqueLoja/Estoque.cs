//Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
using System.Security.Cryptography.X509Certificates;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    private int quantidade;
    public int Quantidade
    {
        get => quantidade;
        set
        {
            if (value < 0)
            {
                quantidade = 0;
            }
            else
            {
                quantidade = value;
            }
        }
    }
    public double preco;
    public double Preco
    {
        get => preco;
        set
        {
            if (value < 0)
            {
                preco = 0.10;
            }
            else
            {
                preco = value;
            }
        }
    }
    public string Marca { get; set; }
    public string Descricao => $"ID: {Id} \nProduto: {Nome} \nQuantidade: {Quantidade} \nPreço: {Preco:C}";

    public void ExibirInformacoes()
    {
        Console.WriteLine(Descricao);
    }

}
public class Estoque
{
    public List<Produto> Produtos { get; set; } = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
        Console.WriteLine($"Produto {produto.Nome} removido do estoque");
    }
        public void ExibirTodosProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }

    }
}
