// Buscando em uma lista
List<string> Chamada = new List<string>
{
    "Ana", "Carlos", "Bianca", "João", "Marina"
};
Console.WriteLine("Digite o nome do aluno: ");
string aluno = Console.ReadLine();
//Muito complicado usar o while, prefiro for ou foreach
int i = 0;
bool encontrado = false;
while (i < Chamada.Count)
{
    if (Chamada[i].Equals(aluno, StringComparison.OrdinalIgnoreCase))
    {
        encontrado = true;
        break; //O break tem que ficar dentro do if se não o i++ não funciona
    } 
    i++;
}
if (encontrado)
{
    Console.WriteLine("Aluno presente!");
} else Console.WriteLine("Aluno não encontrado");

