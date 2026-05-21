//Desafio: conversor de moedas
namespace Alura;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o valor em real: ");
        if (!double.TryParse(Console.ReadLine(), out double real))
        {
            Console.WriteLine("Por favor, digite um valor numérico válido.");
            return;
        }

        Console.WriteLine("Digite a taxa de câmbio: ");
        if (!double.TryParse(Console.ReadLine(), out double cambio) || cambio == 0)
        {
            Console.WriteLine("Taxa de câmbio inválida. O valor não pode ser texto ou zero.");
            return;
        }

        double dolar = real / cambio;

       
        Console.WriteLine($"O valor de R$ {real:F2} convertido em dólar é: U$ {dolar:F2}");
    }
}
