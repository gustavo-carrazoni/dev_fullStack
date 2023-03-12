﻿using Semana02.Classes;
int n = 0;

ContaBancaria conta0 = new ContaBancaria("Cofre", ContaBancaria.TipoConta.POUPANCA);

Console.WriteLine("Bem vindo ao maior banco da América Latina! Por favor, digite os dados da sua conta: ");
Console.Write("Nome do titular: ");
string nomeTitular = Console.ReadLine();

ContaBancaria.TipoConta tipo;
Console.Write("Tipo da Conta: \nDigite 0 para Conta Corrente ou \nDigite 1 para Conta Poupança\n");

if (Console.ReadLine() == "0")
{
    tipo = ContaBancaria.TipoConta.CORRENTE;
}
else
{
    tipo = ContaBancaria.TipoConta.POUPANCA;
}

ContaBancaria conta1 = new ContaBancaria(nomeTitular, tipo);
conta1.AcessoConta();
conta1.Depositar(250);

do { 

    Console.WriteLine("O que gostaria de fazer?\nSaque - 0\nDepósito - 1\nTransferência - 2");
    int i = int.Parse(Console.ReadLine());
    if(i == 0)
    {
        Console.WriteLine("Digite o valor do saque desejado: ");
        float s = float.Parse(Console.ReadLine());
        conta1.Sacar(s);
    }
    if(i == 1)
    {
        Console.WriteLine("Digite o valor para depósito: ");
        float d = float.Parse(Console.ReadLine());
        conta1.Depositar(d);
    }
    if(i == 2)
    {
        Console.WriteLine("Digite o valor que deseja transferir: ");
        float v = float.Parse(Console.ReadLine());
        conta1.Transferir(conta0, v);
    }

    Console.Write("Conta " + nomeTitular);
    conta1.ExibeSaldo();

    Console.Write("Conta Cofre");
    conta0.ExibeSaldo();

    Console.WriteLine("\nDeseja realizar outra operação? \nSim - 0 \nNão - 1");
    n = int.Parse(Console.ReadLine());
}while (n != 1) ;
