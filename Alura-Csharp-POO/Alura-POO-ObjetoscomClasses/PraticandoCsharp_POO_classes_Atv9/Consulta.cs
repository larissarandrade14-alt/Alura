    class Consulta
    {
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }
    public Consulta(string nome, string medico, DateTime data)
    {
        NomeMedico = medico;
        NomePaciente = nome;
        DataConsulta = data;
    }
    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
    }
    public void ExibirResumo()
    {
        Console.WriteLine($"\nPaciente: {NomePaciente} \nMédico: {NomeMedico} \nData da consulta: {DataConsulta}");
    }
}

