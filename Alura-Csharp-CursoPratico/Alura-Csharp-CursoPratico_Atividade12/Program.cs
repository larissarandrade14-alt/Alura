// Controle de estoque
Console.WriteLine("Deseja adicionar um produto ao estoque?");
Console.WriteLine("1 - Sim | 2 - Não");
int resposta = int.Parse(Console.ReadLine());
int total = 0;
while (resposta == 1)
{
    Console.WriteLine("Quantos produtos você gostaria de adicionar? ");
    int quantidade = int.Parse(Console.ReadLine());
    total += quantidade;

    Console.WriteLine("Deseja adicionar um produto ao estoque?");
    Console.WriteLine("1 - Sim | 2 - Não");
    resposta = int.Parse(Console.ReadLine());
}
Console.WriteLine("Quantidade adicionadas: " + total);