/*Crie uma classe chamada Retangulo que tenha:

Duas propriedades públicas: Altura e Largura.
Um método chamado CalcularArea() que retorne a área do retângulo (altura × largura).*/
class Retangulo
    {
    public double Altura { get; set; }
    public double Largura { get; set; }
    public string Identificador { get; set; }
    public void CalcularArea()
    {
        double area = Altura * Largura;
        Console.WriteLine($"A área do {Identificador} é {area}m²");
    }

    }

