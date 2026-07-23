/*Crie um programa que:

Receba um código numérico (1 ou 2) representando o tipo de produto.
Classifique o produto como:
“Perecível” para código 1.
“Não perecível” para código 2.
Alerte o usuário caso o código seja inválido.*/

Console.Write("Digite o código do produto: ");
int opcao = Convert.ToInt16(Console.ReadLine()!);
if (opcao == 1)
{
    Console.WriteLine("Perecível");
} else 
    if (opcao == 2)
    {
        Console.WriteLine("Não perecível");
    }
else
    {
        Console.WriteLine("Código Inválido");
    }
