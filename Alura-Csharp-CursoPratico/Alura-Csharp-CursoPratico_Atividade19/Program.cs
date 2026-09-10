List<int> notas = new List<int> { 5, 9, 4, 6, 7, 8, 5, 9, 10 };

foreach(int nota in notas)
{
    string status; 
    if (nota < 6)
    {
        status = "Reprovado";
    }
    else
    {
        status = "Aprovado";
    }

    Console.WriteLine($"Nota {nota}: {status}");
}