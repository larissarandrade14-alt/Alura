// Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
List<string> bandas = new List<string>();
bandas.Add("Sabotage");
bandas.Add("Emicida");  
bandas.Add("Beyonce");
bandas.Add("Rubel");
bandas.Add("Racionais MC's");

void ExibirBandas()
{
    Console.WriteLine("Minhas bandas prediletas são:");
    for (int i = 0; i<bandas.Count; i++ )
        Console.WriteLine(bandas[i]);
    }

ExibirBandas();