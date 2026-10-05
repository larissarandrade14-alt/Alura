using System.Globalization;

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public Funcionario(string nome, String cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }
    public void Promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        {
            Cargo = novoCargo;
        }
        else
        {
            Console.WriteLine("\nFuncionário já está no cargo digitado");
        }
    }
}

