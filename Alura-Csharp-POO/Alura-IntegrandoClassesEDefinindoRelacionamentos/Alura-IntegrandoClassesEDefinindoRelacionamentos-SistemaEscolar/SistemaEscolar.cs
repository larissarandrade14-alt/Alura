public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Nota { get; set; } = new List<double>();

}

public class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
   
}

public class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();

}