/*Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".*/

Console.WriteLine("Digite sua nota: ");
int notaMedia = Convert.ToInt32(Console.ReadLine());
if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}else 
    if (notaMedia < 5)
    { 
    Console.WriteLine("Nota insuficiente para aprovação");
}
else
{
    Console.WriteLine("Nota inválida");
}




