/* 1.Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, 
     número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
    2.Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.*/

public class Conta
{
    private class Titular
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
    public Titular titular = new Titular();
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Titular: {titular.Nome}");
        Console.WriteLine($"CPF: {titular.CPF}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {NumeroConta}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Limite: {Limite}");
    }
}
