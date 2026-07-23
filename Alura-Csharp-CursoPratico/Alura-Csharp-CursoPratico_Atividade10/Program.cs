// Autenticação de usuário
Console.WriteLine("Sistema de autenticação");
Console.WriteLine("------------------------");

string nomeadmin = "Admin";
Console.WriteLine("Digite seu nome: ");
string usuario = Console.ReadLine();
if (usuario == nomeadmin)
{
    Console.WriteLine($"Bem-vindo ao sistema, {nomeadmin}!");
}
else
{
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] Cadastrar novo usuário");
    Console.WriteLine("[2] Acessar como convidado");
    Console.WriteLine("[3] Sair");
    
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Novo usuário {usuario} cadastrado com sucesso");
            break;
        case 2: Console.WriteLine("Entrando como convivado...");
            break;
        case 3: Console.WriteLine("Finalizando acesso...");
            break;
        default:
            Console.WriteLine("Opção inválida. O sistema será encerrado.");
            break;
    }
}
