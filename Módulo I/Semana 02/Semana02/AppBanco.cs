using Semana02.Classes;

ContaBancaria conta1 = new ContaBancaria();

Console.WriteLine("Bem vindo ao maior banco da América Latina! Por favor, digite os dados da sua conta: ");
Console.Write("Nome do titular: ");
conta1.titular = Console.ReadLine();

Console.Write("\nAgência: ");
conta1.agencia = int.Parse(Console.ReadLine());

Console.Write("Número da conta: ");
conta1.numero = int.Parse(Console.ReadLine());

Console.Write("Tipo da Conta: \nDigite 0 para Conta Corrente ou \nDigite 1 para Conta Poupança\n");

if(Console.ReadLine() == "0")
{
    conta1.tipo = TipoConta.CORRENTE;
}
else
{
    conta1.tipo = TipoConta.POUPANCA;
}

Console.WriteLine("Seu nome é " + conta1.titular + " e possui uma Conta " + conta1.tipo + " na agência " + conta1.agencia + ", de número " + conta1.numero + ".");

Console.Write("\nSeu saldo atual é R$ " + conta1.saldo + ".");
