/*Imagine que você está desenvolvendo uma aplicação para uma biblioteca que precisa cadastrar livros. 
 * Cada livro deve ter um título e um autor.
 * Crie uma classe chamada Livro que possua 
 * duas propriedades públicas: Titulo e Autor. 
 * Depois, crie um objeto dessa classe e preencha os dados com um título e autor de sua escolha e exiba a saída.*/

Livro livro1 = new Livro();
livro1.Titulo = "Capitães da Areia";
livro1.Autor = "Jorge Amado";

Console.WriteLine("Livro: " + livro1.Titulo);
Console.WriteLine("Autor: " + livro1.Autor);