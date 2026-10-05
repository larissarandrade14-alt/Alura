//validação de acesso a filmes
class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }
    public Filme (string titulo, int classificacao)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacao;
    }
    public bool PodeAssistir (int idade)
    {
        return idade >= ClassificacaoEtaria;
    }

    public void Resultado(int idade)
    {
        if (PodeAssistir(idade))
        {
            Console.WriteLine("Usuário pode ver ao filme");
        }
        else
        {
            Console.WriteLine("Usuário possui idade menor que a Classificação etária, selecione outro filme");
        }
    }
    

    

}