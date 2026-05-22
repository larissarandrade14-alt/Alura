class ContaBancaria
{
    public string titular;
    public string senha;
    public int numeroIdentificacao;
    public double saldo;

    public void ExibirDadosCompletos()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Número de Identificação: {numeroIdentificacao}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Senha: {senha}");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"\nO saldo na conta pertencente a {titular} é R${saldo}");
    }
}