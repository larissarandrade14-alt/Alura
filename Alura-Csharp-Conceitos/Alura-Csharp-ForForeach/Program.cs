List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

void ImprimirNumeros()
{
    foreach (int numero in numeros)
    {
       
        Console.WriteLine(numero);
    }
}
void MostrarNumeros()
{
    for (int i = 0; i < numeros.Count; i++)
    {
        
        Console.WriteLine(numeros[i]);
    }
}
Console.WriteLine($"Usando o foreach:");
ImprimirNumeros();
Console.WriteLine("Usando o for:");
MostrarNumeros();