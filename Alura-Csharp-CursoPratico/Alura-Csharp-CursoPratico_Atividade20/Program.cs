string mensagem;

List<double> notas = new List<double>
        {
    8.5,
    6.2,
    9.1,
    5.8,
    7.4,
    7.0
        };
foreach(double nota in notas)
{
    if (nota < 7.0)
    {
        mensagem = "está abaixo da média!";
    }
    else
    {
        mensagem = "está indo muito bem!";
    }
    Console.WriteLine($"O aluno com nota {nota} {mensagem}");
}
