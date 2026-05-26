/*  1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
    2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
    3. Desenvolver um método da classe Conta que exibe suas informações.*/
class ContaBancaria
{
    public string titular {get;set}
    public string senha { get; set}
    public int numeroIdentificacao { get; set}
    public double saldo { get; set}

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