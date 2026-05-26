namespace ProjetoCarro.Models
{
    public class Carro
    {
        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        private int ano;
        public int Ano
        {
            get => ano;
            set
            {
                if (value < 1960 || value > 2023)
                {
                    Console.WriteLine("Valor inválido para o ano. O valor deve estar entre 1960 e 2023.");
                }
                else { ano = value; }
            }
        }
        public int QuantidadePortas { get; set; }


        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações do carro: \nFabricante: {Fabricante} \nModelo: {Modelo} \nPortas: {QuantidadePortas} portas \nAno de fabricação: {ano}");
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando...");
        }
        public void Frear()
        {
            Console.WriteLine("O carro está freando...");
        }
        public void Buzinar()
        {
            Console.WriteLine("BIBIBI");
        }
    }
}