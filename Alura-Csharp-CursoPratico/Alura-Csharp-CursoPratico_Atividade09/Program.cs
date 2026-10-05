// Refatorando a organização de livros

Console.WriteLine("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine());
string livro = codigo switch
{
    >= 100 and <= 199 => "Ficção Científica",
    >= 200 and <= 299 => "Literatura Clássica",
    >= 300 and <= 399 => "Fantasia",
    >= 400 and <= 499 => "Romance",
    >= 500 and <= 599 => "Suspense/Mistério",
    >= 600 and <= 699 => "Não Ficção",
    >= 700 and <= 799 => "Biografias/Memórias",
    >= 800 and <= 899 => "Distopia",
    >= 900 and <= 999 => "Infantojuvenil",
    _ => "Código inexistente"

};

Console.WriteLine(livro);


