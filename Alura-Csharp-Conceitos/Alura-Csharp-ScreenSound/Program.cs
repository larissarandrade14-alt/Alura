//Screen Sound
string MensagemDeBoasVindas = "Bem-vindo ao Screen Sound!";
List<string> bandasRegistradas = new List<string>();
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");


    Console.WriteLine(MensagemDeBoasVindas);
}
void ExibirMenuPrincipal()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("\nDigite sua opção: ");
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine()!);
    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Opção 3 selecionada: Avaliar uma banda");
            break;
        case 4:
            Console.WriteLine("Opção 4 selecionada: Exibir a média de uma banda");
            break;
        case 0:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
    void RegistrarBanda()
    {
        Console.Clear(); //Para limpar a tela antes de registrar a banda
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda);
        Console.WriteLine($"Banda '{nomeDaBanda}' registrada com sucesso!"); //Interpolação de string
        Thread.Sleep(2000); //Aguarda 2 segundos antes de voltar ao menu principal
        Console.Clear();
        ExibirMenuPrincipal();
    }
    void MostrarBandasRegistradas()
    {
        Console.Clear();
       foreach (string banda in bandasRegistradas)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Thread.Sleep(2000); //Aguarda 2 segundos antes de voltar ao menu principal
        Console.Clear();
        ExibirMenuPrincipal();
    }
}

ExibirMensagemDeBoasVindas();
ExibirMenuPrincipal();