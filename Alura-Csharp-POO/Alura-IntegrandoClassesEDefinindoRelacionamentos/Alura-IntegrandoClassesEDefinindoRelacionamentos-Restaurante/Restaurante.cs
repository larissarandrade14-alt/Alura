public class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new List<Mesa>();
    public void MesaDisponivel(Mesa mesa)
    {
        if (mesa.Ocupada == false)
            Console.WriteLine("Mesa disponível para reserva");
        else Console.WriteLine("Mesa ocupada, selecione outra mesa para reserva");
    }
    public List<string> Cardapio { get; set; } = new List<string> { "Pizza", "Hambúrguer", "Salada", "Sopa", "Frango Assado" };
}
public class Mesa
{
    public int Numero { get; set; }
    public bool Ocupada { get; set; }

}
public class Pedidos
{
    public void FazerPedido(Restaurante restaurante)
    {
        int numeroMesa;

        while (true)
        {
            Console.WriteLine("Digite o número da mesa:");

            bool numeroValido =
                int.TryParse(Console.ReadLine(), out numeroMesa);

            if (numeroValido)
                break;

            Console.WriteLine("Digite apenas números.");
        }

        Mesa mesaEncontrada = restaurante.Mesas.FirstOrDefault(m => m.Numero == numeroMesa);
        if (mesaEncontrada == null)
        {
            Console.WriteLine("Mesa não encontrada. Pedido não realizado.");
            return;
        }
        if (mesaEncontrada.Ocupada)
        {
            Console.WriteLine("=== CARDÁPIO ===");

            foreach (var item in restaurante.Cardapio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nRealize seu pedido: ");
            string pedidoRealizado = Console.ReadLine();
            string pedidoCardapio = restaurante.Cardapio.FirstOrDefault(p => p.Equals(pedidoRealizado, StringComparison.OrdinalIgnoreCase));
            switch (pedidoCardapio)
            {



                case "Pizza":
                    Console.WriteLine("Pedido de Pizza realizado com sucesso!");
                    break;
                case "Hambúrguer":
                    Console.WriteLine("Pedido de Hambúrguer realizado com sucesso!");
                    break;
                case "Salada":
                    Console.WriteLine("Pedido de Salada realizado com sucesso!");
                    break;
                case "Sopa":
                    Console.WriteLine("Pedido de Sopa realizado com sucesso!");
                    break;
                case "Frango Assado":
                    Console.WriteLine("Pedido de Frango Assado realizado com sucesso!");
                    break;
                default:
                    Console.WriteLine("Item não encontrado no cardápio.");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Mesa livre, não há como fazer pedidos.");
        }
    }
}
