// Soma das vendas
Dictionary<string, List<double>> Vendas = new Dictionary<string, List<double>>();

string vendedor;
double valorVendas;
do
{
    Console.WriteLine("Digite o nome do vendedor: ");
    vendedor = Console.ReadLine();
    if (!Vendas.ContainsKey(vendedor))
    {
        Vendas[vendedor] = new List<double>();
    }
    do
    {
        Console.WriteLine("Digite o valor da venda ou 0 para sair: ");
        valorVendas = double.Parse(Console.ReadLine());
        if (valorVendas != 0)
        {
            Vendas[vendedor].Add(valorVendas);
        }
    } while (valorVendas != 0);
    foreach (var vendedorVendas in Vendas)
    {
        double total = vendedorVendas.Value.Sum();
        Console.WriteLine($"Vendedor {vendedorVendas.Key}: Total de vendas = {total}");
    }

} while (valorVendas != 0);


