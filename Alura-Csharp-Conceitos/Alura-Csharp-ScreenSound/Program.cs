//Screen Sound
string MensagemDeBoasVindas = "Bem-vindo ao Screen Sound!";
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
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
}

ExibirMensagemDeBoasVindas();
ExibirMenuPrincipal();