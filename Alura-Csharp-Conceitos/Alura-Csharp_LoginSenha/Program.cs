// Criar um programa que simule um sistema de login utilizando
// um dicionário para armazenar nomes de usuário e senhas.

Dictionary<string, string> LoginSenha = new Dictionary<string, string>
{
    {"mariamaria123", "123mama123" },
    {"joaojoao321", "321joaozinho" },
    {"senhordosgames", "joguinho123" }
};
void MensagemInicial()
{
    Console.WriteLine("Bem vindo ao");
    Console.WriteLine(@"

███████████████████████████████████████████████████████████████████████████████████████████████████████
█▄─▄─▀█▄─▄▄─█▄─▀█▀─▄█▀▀▀▀▀██▄─█─▄█▄─▄█▄─▀█▄─▄█▄─▄▄▀█─▄▄─████▀▄─██─▄▄─███─▄▄▄─█▄─▄███▄─██─▄█▄─▄─▀█▄─▄▄─█
██─▄─▀██─▄█▀██─█▄█─██████████▄▀▄███─███─█▄▀─███─██─█─██─████─▀─██─██─███─███▀██─██▀██─██─███─▄─▀██─▄█▀█
▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▀▄▄▄▀▀▀▀▀▀▀▀▀▀▄▀▀▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▄▀
█████████████████████████████▀██████
█▄─▄▄▀█─▄▄─█████▄─▄█─▄▄─█─▄▄▄▄█─▄▄─█
██─██─█─██─███─▄█─██─██─█─██▄─█─██─█
▀▄▄▄▄▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀");
}
void MenuPrincipal()
{
        Console.WriteLine("Se já possui cadastro digite 1");
    Console.WriteLine("Para cadastrar-se digite 2");
    Console.Write("Sua opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {

        case 1:
            Realizarlogin();
            break;
        case 2:
            Cadastrar();
            break;

    }
}
void Realizarlogin()
{
    Console.Clear();
    Console.WriteLine("Digite seu login: ");
    string login = Console.ReadLine()!;
        if (LoginSenha.ContainsKey(login))
    {
        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine()!;
        if (LoginSenha.ContainsValue(senha))
        {
            MensagemInicial();
        }
        else
        {
            Console.WriteLine("Senha incorreta, tente novamente");
            Thread.Sleep(2000);
            Console.Clear();

            MenuPrincipal();
        }
    } else
    {
        Console.WriteLine("Usuário não encontrado");
        Thread.Sleep(2000);
        Console.Clear();

        MenuPrincipal();
    }
}
void Cadastrar()
{
    Console.Clear();
    Console.WriteLine("Digite seu login: ");
    string login = Console.ReadLine()!;
    if (LoginSenha.ContainsKey(login))
    {
        Console.WriteLine("Usuário já existe");
        Thread.Sleep(2000);
        Console.Clear();
        MenuPrincipal();
    }else
    {

        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine()!;
        Thread.Sleep(2000);
        Console.WriteLine("Usuário cadastrado com sucesso!");
        Realizarlogin();

    }
}

MensagemInicial();
MenuPrincipal();