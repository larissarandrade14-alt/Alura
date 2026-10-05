 public class ProdutoDigital
    {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTec { get; set;  }
    public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
    {
        Nome = nome;
        Preco = preco;
        InfoTec = info;
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nProduto: {Nome}\nPreço: {Preco}\nTamanho:{InfoTec.TamanhoMB}MB\nCompatibilidade Operacional: {InfoTec.SistemaOperacional} ");
    }
}

