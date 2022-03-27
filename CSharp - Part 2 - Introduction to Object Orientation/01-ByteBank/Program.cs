// See https://aka.ms/new-console-template for more information
ContaCorrente contaDoEvan = new ContaCorrente();

contaDoEvan.titular = "Evan";
contaDoEvan.agencia = 863;
contaDoEvan.numero = 863452;
contaDoEvan.saldo = 100;

Console.WriteLine(contaDoEvan.titular);
Console.WriteLine("Agência: " + contaDoEvan.agencia);
Console.WriteLine("Número: " + contaDoEvan.numero);
Console.WriteLine("Saldo: " + contaDoEvan.saldo);

contaDoEvan.saldo += 200;
Console.WriteLine("Saldo: " + contaDoEvan.saldo);

Console.ReadLine();


