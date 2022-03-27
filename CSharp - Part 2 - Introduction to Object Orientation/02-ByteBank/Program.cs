// See https://aka.ms/new-console-template for more information
ContaCorrente conta = new ContaCorrente();

conta.titular = "Evan";
Console.WriteLine("Saldo: " + conta.saldo);

conta.saldo = 200;

Console.WriteLine(conta.titular);
Console.WriteLine("Agência: " + conta.agencia);
Console.WriteLine("Saldo: " + conta.saldo);

Console.ReadLine();
