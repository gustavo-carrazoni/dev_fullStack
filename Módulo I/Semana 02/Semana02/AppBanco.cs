using Semana02.Classes;
int n = 0;

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
        conta1.tipo = ContaBancaria.TipoConta.CORRENTE;
    }
    else
    {
        conta1.tipo = ContaBancaria.TipoConta.POUPANCA;
    }

    Console.WriteLine("Seu nome é " + conta1.titular + " e possui uma Conta " + conta1.tipo + " na agência " + conta1.agencia + ", de número " + conta1.numero + ".");

    do { 

        Console.WriteLine("O que gostaria de fazer?\nSaque - 0\nDepósito - 1");
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


        conta1.ExibeSaldo();
        Console.WriteLine("Deseja realizar outra operação? \nSim - 0 \nNão - 1");
        n = int.Parse(Console.ReadLine());
    }while (n != 1) ;