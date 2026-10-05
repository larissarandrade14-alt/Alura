/*Crie uma classe chamada ContaBancaria que tenha:

Uma propriedade pública NumeroConta.
Uma propriedade pública Saldo.
Um método Depositar(double valor) que adicione o valor ao saldo existente.*/

ContaBancaria conta = new ContaBancaria();
    conta.Saldo = 1000m;
    conta.NumeroConta = 12345; 

Console.WriteLine($"Conta: {conta.NumeroConta}");
Console.WriteLine($"Saldo atual: {conta.Saldo}");

conta.Depositar(600m);

Console.WriteLine($"Saldo atualizado após depósito: {conta.Saldo}");
