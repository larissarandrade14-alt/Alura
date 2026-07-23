// Verificando acesso a área restrita
Console.WriteLine("Digite a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite seu nível de acesso: ");
int acesso = Convert.ToInt32(Console.ReadLine());
if(senha == 42 && acesso >= 5 )
{
    Console.WriteLine("Acesso Liberado");
} else
{
    Console.WriteLine("Acesso Bloqueado");
}