//Screen Sound
string MensagemDeBoasVindas = "Bem-vindo ao Screen Sound!";
//List<string> bandasRegistradas = new List<string>();

Dictionary<string, List<double>> bandasRegistradas = new Dictionary<string, List<double>>();
bandasRegistradas.Add("Linkin Park", new List<double> { 8.5, 9.0, 7.5 });
bandasRegistradas.Add("Imagine Dragons", new List<double>());

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
            AvaliarBanda();
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
        ExibirTituloDaOpcao ("Registro de Bandas");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<double>());
        Console.WriteLine($"Banda '{nomeDaBanda}' registrada com sucesso!"); //Interpolação de string
        Thread.Sleep(2000); //Aguarda 2 segundos antes de voltar ao menu principal
        Console.Clear();
        ExibirMenuPrincipal();
    }
    void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao ("Bandas Registradas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Thread.Sleep(2000); //Aguarda 2 segundos antes de voltar ao menu principal
        Console.Clear();
        ExibirMenuPrincipal();
    }
}
void AvaliarBanda()
{
    //Digitar qual a banda que deseja avaliar
    //Verificar se existe a banda no dicionário
    //Se existir, atribuir a nota a banda
    //Se não existir volta ao menu principal
    Console.Clear ();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite a nota para a banda '{nomeDaBanda}': ");
        double nota = Convert.ToDouble(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nNota {nota} adicionada para a banda '{nomeDaBanda}' com sucesso!");
        Thread.Sleep(3000); 
        Console.Clear();
        ExibirMenuPrincipal();
    } else
    {
        Console.WriteLine($"\nA banda '{nomeDaBanda}' não está registrada.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuPrincipal();
    }
}
void ExibirTituloDaOpcao(string titulo)
{
   int quantidadeDeLetras = titulo.Length;
    string asteriscos =string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n" );
}

ExibirMensagemDeBoasVindas();
ExibirMenuPrincipal();