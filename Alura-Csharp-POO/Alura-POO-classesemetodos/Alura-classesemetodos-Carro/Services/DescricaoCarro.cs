using ProjetoCarro.Models;

namespace ProjetoCarro.Services
{
    public class DescricaoCarro
    {
        public static Carro CriarCarro()
        {
            Carro carro1 = new Carro();

            carro1.Modelo = "Civic";
            carro1.Fabricante = "Honda";
            carro1.QuantidadePortas = 4;
            carro1.Ano = 2020;
         
            return carro1;
        }
    }
}