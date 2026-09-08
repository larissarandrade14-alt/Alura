// Número secreto
int secreto = 4;
Console.WriteLine("Tente adivinhar o número de 0 a 10: ");
int tentativa = int.Parse(Console.ReadLine());

while(tentativa != secreto)
{
    Console.WriteLine("Você não acertou ");
    Console.WriteLine("Tente novamente: ");
    tentativa = int.Parse(Console.ReadLine());

}
Console.WriteLine("Você acertou!");