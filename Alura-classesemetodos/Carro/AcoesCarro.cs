
Console.WriteLine("Digite a ação do carro: ");
string acaoCarro = Console.ReadLine();
if (acaoCarro == "acelerar")
{
    Carro carro = new Carro();
    carro.Acelerar();
}
else
    if (acaoCarro == "Acelerar")
    {
        Carro carro = new Carro();
        carro.Acelerar();
    }
    else
        if (acaoCarro == "frear")
        {
            Carro carro = new Carro();
            carro.Frear();
        }
        else
            if (acaoCarro == "Frear")
            {
                Carro carro = new Carro();
                carro.Frear();
            }
            else if (acaoCarro == "buzinar")
            {
                Carro carro = new Carro();
                carro.Buzinar();
            }
            else
                if (acaoCarro == "Buzinar")
                {
                    Carro carro = new Carro();
                    carro.Buzinar();
                }
                else
                {
                    Console.WriteLine("Ação inválida.");
                }

