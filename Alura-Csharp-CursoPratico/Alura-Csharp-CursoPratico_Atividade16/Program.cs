// Conversor de temperatura
int opcao; // A variável deve ser definida fora de qualquer contexto para ser aplicada no while do final 
do //O menu deve estar dentro do "do" para não entrar em loop infinito 
{
    Console.Write(@"1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Sair
Digite uma opção: ");
    
    opcao = int.Parse(Console.ReadLine());
    
    double conversao = 0.0;

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Celcius para Fahrenheit");
            Console.WriteLine("Digite a temperatura: ");
            double temp = double.Parse(Console.ReadLine());
            conversao = (temp * 9 / 5) + 32;
            Console.WriteLine($"A temperatura em Celcius é {conversao:F2}°C");
            break;
        case 2:
            Console.WriteLine("Fahrenheit para Celcius");
            Console.WriteLine("Digite a temperatura: ");
            temp = double.Parse(Console.ReadLine());
            conversao = (temp - 32) * 5 / 9;
            Console.WriteLine($"A temperatura em Fahrenheit é {conversao:F2}°F");
            break;
        case 3:
            Console.WriteLine("Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
} while (opcao != 3 ); //Ainda não sei como solucionar o erro ao ser digitado uma letra 