// Escrever uma função que a partir de dois números de ponto flutuante a e b
// exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação),
// utilizando interpolação de strings.

Console.WriteLine("Digite o primeiro número a:");
double a = double.Parse(Console.ReadLine()); //Utilizei o método Parse para converter a entrada do usuário em um número flutuante (double)

Console.WriteLine("Digite o segundo número b:");
double b = double.Parse(Console.ReadLine());

double soma = a + b; //Escrevi funções para realizar as quatro operações básicas
double subtracao = a - b;
double multiplicacao = a * b;
double divisao = a / b;

Console.WriteLine($"Soma a+b: {soma}"); //Utilizei interpolação de strings para exibir o resultado da soma
Console.WriteLine($"Subtração a-b: {subtracao}");
Console.WriteLine($"Multiplicação a*b: {multiplicacao}");
Console.WriteLine($"Divisão a/b: {divisao}");