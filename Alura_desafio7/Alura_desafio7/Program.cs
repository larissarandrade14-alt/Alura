//Desafio: conversor de moedas
namespace Alura;

public class Program
{
    public static void Main()
    { 
    Console.WriteLine("Digite o valor em real: ");
       double real = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a taxa de câmbio: ");
       double cambio = double.Parse(Console.ReadLine());
    double dolar = real / cambio;
        Console.WriteLine("o valor em dólar é: " + dolar);
    }
}
