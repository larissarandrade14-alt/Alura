int contador = 0;
for (int i = 1; i<=10; i++)
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine()!);
    
    if(numero % 2 != 0)
    {
        contador++;
    }
    else
    {
        continue;
    }
}
Console.WriteLine($"Você digitou {contador} números ímpares");
