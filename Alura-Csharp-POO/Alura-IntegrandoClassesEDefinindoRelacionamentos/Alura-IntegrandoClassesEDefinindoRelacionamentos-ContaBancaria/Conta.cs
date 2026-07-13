/* 1/* 1.Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, 
     número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
    2.Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.*/


public class Conta
{
    public Conta(Titular titular, int agencia, int numeroConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Limite = limite;
    }

    public Titular Titular { get;  }
    public int Agencia { get; }
    public int NumeroConta { get;  }
    public double Saldo { get;  }
    public double Limite { get;  }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Titular: {Titular.Nome}");
        Console.WriteLine($"CPF: {Titular.CPF}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {NumeroConta}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Limite: {Limite}");
    }


}