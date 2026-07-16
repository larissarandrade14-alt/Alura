// Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
void SomarLista(List<int> lista)
{
    int soma = 0;
    foreach (int numero in lista)
    {
        soma += numero;
    }
    Console.WriteLine($"A soma dos elementos da lista é: {soma}");
}

SomarLista(numeros);