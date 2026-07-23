// Sistema de recompensas
using System.Threading.Channels;

Console.WriteLine("Digite seu cupom: ");
string cupom = Console.ReadLine();


string mensagem = cupom switch
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora",
    "CURAR" => "Você ganhou uma poção de cura!",
    "OURO" => "Você ganhou 1000 moedas de ouro",
    "ESPECIAL" => "Você ganhou um item lendário",
    _ => "Recompensa não localizada"
};
Console.WriteLine(mensagem);