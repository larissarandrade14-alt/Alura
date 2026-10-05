public class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(string titulo, int duracao, int ordem)
{
    Titulo = titulo;
    Duracao = duracao;
    Ordem = ordem;
}

    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"Episódio {Ordem}. {Titulo} - Duração: {Duracao} segundos - {string.Join(",", convidados)}";

   
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}

