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
void NumerosParesForeach()
{
    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine(numero);
        }
    }
}
void NumerosParesFor()
{
for (int i=0; i<numeros.Count; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

Console.WriteLine($"Usando o foreach:\n");
Console.WriteLine("Todos os números: ");
ImprimirNumeros();
Console.WriteLine("Apenas os números pares: ");
NumerosParesForeach();
Console.WriteLine("\nUsando o for:\n");
Console.WriteLine("Todos os números: ");
MostrarNumeros();
Console.WriteLine("Apenas os números pares: ");
NumerosParesFor();