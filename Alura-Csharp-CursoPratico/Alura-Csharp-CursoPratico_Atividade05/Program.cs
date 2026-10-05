// Classificando a faixa etária
Console.WriteLine("Digite a idade do cliente: ");
int idade = Convert.ToInt32(Console.ReadLine());
if (idade>= 60)
{
    Console.WriteLine("Categoria idoso");
} else
    if (idade < 60 && idade>17)
    {
        Console.WriteLine("Categoria adulto");
    } else 
        if(idade <18 && idade > 12)
        {
            Console.WriteLine("Categoria adolescente");
        } else 
            if(idade<13 && idade >= 0)
            {
                Console.WriteLine("Categoria infantil");
            } else
            {
                Console.WriteLine("Idade inválida");
            }
