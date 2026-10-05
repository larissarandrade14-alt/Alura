public class InformacaoTecnica
    {
    public string SistemaOperacional { get; set; }
    public int TamanhoMB { get; set; }
    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;

    }
}
