// Crie um programa que implemente um quiz simples de perguntas e respostas.
// Utilize um dicionário para armazenar as perguntas e as respostas corretas.

Dictionary<string, string> Quiz = new Dictionary<string, string>
{
    { "Qual a capital da Bahia?", "Salvador" },
    {"Qual a data que se comemora a Independência do Brasil?", "7 de setembro" },
    {"Qual o menor estado do Brasil?", "Sergipe" },
    {"Qual a capital do Brasil?", "Brasília" }
};

int pontos = 0;
foreach (var perguntas in Quiz)
{
    Console.Write($"{perguntas.Key} ");
    string resposta = Console.ReadLine()!;
    if (resposta.ToLower() == perguntas.Value.ToLower())
    {
        Console.WriteLine("Resposta correta!\n");
        pontos++;
    } else
        Console.WriteLine($"Resposta incorreta. A resposta é: {perguntas.Value}\n");

}
Console.WriteLine($"A pontuação final é de: {pontos} pontos");