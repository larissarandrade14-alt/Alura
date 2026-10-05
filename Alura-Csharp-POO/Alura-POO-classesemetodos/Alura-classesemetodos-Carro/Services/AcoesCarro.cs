using ProjetoCarro.Models;

namespace ProjetoCarro.Services
{
    public class AcoesCarro
    {
        public void Executar(Carro carro)
        {
            Console.WriteLine("\nDigite a ação do carro: ");
            string acaoCarro = Console.ReadLine().ToLower();

            switch (acaoCarro)
            {
                case "acelerar":
                    carro.Acelerar();
                    break;

                case "frear":
                    carro.Frear();
                    break;

                case "buzinar":
                    carro.Buzinar();
                    break;

                default:
                    Console.WriteLine("Ação inválida.");
                    break;
            }
        }
    }
}

