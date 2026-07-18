// Criar um programa que gerencie o estoque de uma loja.
// Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre,
// a partir do nome de um produto, sua quantidade em estoque.
Dictionary<string, int> produtos = new Dictionary<string, int>
{
    { "Sabonete", 10 },
    { "Shampoo", 8},
    { "Condicionador", 11},
    { "Máscara facial", 6},
    { "hidratante labial", 15}
};
void MostrarProduto()
{
    Console.WriteLine("Digite o produto que deseja encontrar: ");
    string produto = Console.ReadLine()!;

    foreach (var item in produtos)
    {
        if (produto == item.Key)
        {
            Console.WriteLine($"O estoque possui {item.Value} do item {item.Key}");
            return;
        }
            
    }
    Console.WriteLine($"Não há o produto {produto} em estoque");
}
    
MostrarProduto();