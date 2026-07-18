// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

Dictionary<string, List<double>> alunoNotas = new Dictionary<string, List<double>>();
alunoNotas.Add("João", new List<double> { 8.5, 7.0, 9.0 });
alunoNotas.Add("Maria", new List<double> { 9.5, 8.0, 10.0 });
alunoNotas.Add("Pedro", new List<double> { 6.0, 7.5, 8.0, 3.5, 5.5 });

void MediaNotas()
{
    foreach (var aluno in alunoNotas)
    {
        double media = aluno.Value.Average();
        Console.WriteLine($"A média do aluno {aluno.Key} é: {media:F2}");

    }
}
MediaNotas();