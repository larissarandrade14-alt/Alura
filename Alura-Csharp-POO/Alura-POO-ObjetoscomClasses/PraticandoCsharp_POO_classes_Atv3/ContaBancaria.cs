/*Crie uma classe chamada ContaBancaria que tenha:

Uma propriedade pública NumeroConta.
Uma propriedade pública Saldo.
Um método Depositar(double valor) que adicione o valor ao saldo existente.*/

class ContaBancaria
    {
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public void Depositar(decimal deposito)
    {
        Saldo = Saldo + deposito;
    }
    }
