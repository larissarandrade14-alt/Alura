namespace Aula02;

public class Program
{
    public static void Main()
    {
        double valor_entrega_5 = 5.00;
        double valor_entrega_10 = 8.00;
        double valor_entrega_maior = 10.00;
        Console.WriteLine("Digite a distância do pedido em km: ");
        double distancia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Está chovendo?(s/n) ");
        string chuva = Console.ReadLine();
        if (distancia <= 5 && chuva == "n")
        {
            Console.WriteLine($"O valor da entrega é: R${valor_entrega_5}");
        }
        else if (distancia <= 5 & chuva == "s")
        {
            Console.WriteLine($"O valor da entrega é: R${valor_entrega_5 + 2}");
        }
        else if (distancia <= 10 && chuva == "s" && distancia >5)
        {
            Console.WriteLine($"O valor da entrega é: R${valor_entrega_10 + 2}");
        }
        else if (distancia <= 10 && chuva == "n" && distancia > 5)
        {
            Console.WriteLine($"O valor da entrega é: R${valor_entrega_10}");
        }
        else if (distancia > 10 && chuva == "s" )
        {
            Console.WriteLine($"O valor da entrega é: R${valor_entrega_maior + 2}");
        }
        else
        {
            Console.WriteLine($"O valor da entrega é: R${valor_entrega_maior}");
        }
    }
}
