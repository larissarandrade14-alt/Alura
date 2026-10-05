// Verificando o saldo da conta
Console.WriteLine("Digite o saldo da conta: ");
decimal saldo = decimal.Parse(Console.ReadLine());
if (saldo > 0)
{
    Console.WriteLine("O saldo é positivo");
}
else
    if (saldo < 0)
    {
        Console.WriteLine("O saldo é negativo");
    }
    else
    {
        Console.WriteLine("O saldo é zero");
    }