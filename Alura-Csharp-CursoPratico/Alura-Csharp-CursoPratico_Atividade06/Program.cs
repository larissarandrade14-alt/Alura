// Calculadora de operações básicas
using System.Security.AccessControl;

Console.WriteLine("Digite o primeiro valor: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Digite + para soma");
Console.WriteLine("Digite - para subtração");
Console.WriteLine("Digite * para multiplicação");
Console.WriteLine("Digite / para divisão");
Console.WriteLine("Escolha qual das quatro operações você gostaria: ");
string operacao = Console.ReadLine();

switch (operacao)
{
    case "+":
        Console.WriteLine("Resultado da soma: " + (a+b));
        break;
    case "-":
        Console.WriteLine("Resultado da subtração: " + (a-b));
        break;
    case "*":
        Console.WriteLine("Resultado da multiplicação: " + (a*b));
        break;
    case "/":
        Console.WriteLine("Resultado da divisão: " + (a/b));
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}