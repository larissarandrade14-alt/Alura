/*Crie uma classe chamada Funcionario que tenha:

Uma propriedade pública Nome.
Uma propriedade pública Cargo.
Um construtor que receba nome e cargo como parâmetros obrigatórios.
Um método chamado Promover(string novoCargo) que atualize o cargo do funcionário, 
somente se o novo cargo for diferente do atual. Se for o mesmo, 
exiba uma mensagem de erro informando que a promoção não pode ocorrer.*/

Funcionario funcionario = new Funcionario("Larissa Andrade", "Desenvolvedora Junior");

Console.WriteLine("\nInformações do funcionário:");
Console.WriteLine($"Nome: {funcionario.Nome}");
Console.WriteLine($"Cargo: {funcionario.Cargo}");

funcionario.Promover("Desenvolvedora Junior");

funcionario.Promover("Desenvolvedora Pleno");

Console.WriteLine("\nInformações do funcionário:");
Console.WriteLine($"Nome: {funcionario.Nome}");
Console.WriteLine($"Cargo: {funcionario.Cargo}");
