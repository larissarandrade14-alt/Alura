// Saudação personalizada
Console.WriteLine("Olá querido aluno! Em qual turno estamos falando agora:");
Console.WriteLine("manhã, tarde ou noite? Digite sua resposta: ");
string turno = Console.ReadLine();
Console.WriteLine("Para continuarmos, me informe como gostaria de ser chamado por favor: ");
string nome = Console.ReadLine();
switch (turno)
{
    case "manhã":
        Console.WriteLine($"Bom dia,{nome}!");
        break;
    case "tarde":
        Console.WriteLine($"Boa tarde,{nome}!");
        break;
    case "noite":
        Console.WriteLine($"Boa noite,{nome}!");
        break;
    default:
        Console.WriteLine("Vamos tentar novamente!");
        break;
}
