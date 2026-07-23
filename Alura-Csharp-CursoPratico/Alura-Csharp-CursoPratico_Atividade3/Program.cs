// Classificando a nota de um aluno
Console.WriteLine("Digite a média final do aluno: ");
double media = double.Parse(Console.ReadLine());
if (media >= 9.0)
{
    Console.WriteLine("Aluno honra ao mérito! Parabéns!");
} else
    if (media >= 7.0) 
    {
        Console.WriteLine("Aluno aprovado!");
    } else
        if(media >= 5.0) 
        {
            Console.WriteLine("Aluno em recuperação");
        } else
            if (media < 5)
            {
                Console.WriteLine("Aluno reprovado");
            }

