using Semana_04.Classes;


Cliente cliente1 = new Cliente("Gus", DateTime.Parse("12/04/1995"), "Monitor", Semana_04.Classes.Enum.EstadoCivil.SOLTEIRO, Semana_04.Classes.Enum.TipoPessoa.FISICA);

Console.WriteLine($"Foi cadastrado o cliente chamado {cliente1.Nome}, nascido em {cliente1.Nascimento:d}," +
    $" trabalha como {cliente1.Profissao}," +
    $" {cliente1.EstadoCivil}, pessoa {cliente1.TipoPessoa}.");

Console.WriteLine("\nCriando conta para este cliente.");

    Random r = new Random();
    int n = r.Next(00, 100);
    int a = r.Next(00, 100);

    ContaBancaria conta1 = new ContaBancaria(n, a, cliente1);
    conta1.Depositar(250);

Console.WriteLine($"Conta criada: \nNumero {conta1.Numero}, \nAgencia {conta1.Agencia}, \nSaldo R$ {conta1.Saldo}");

Console.WriteLine("Criando segunda conta.");
    
    n = r.Next(00, 100);
    a = r.Next(00, 100);
Cliente cliente2 = new Cliente("Cliente 2", DateTime.Parse("20/03/2001"), "Vendedor", Semana_04.Classes.Enum.EstadoCivil.CASADO, Semana_04.Classes.Enum.TipoPessoa.FISICA);

    ContaBancaria conta2 = new ContaBancaria(n, a, cliente2);

Console.WriteLine($"\nConta criada para {cliente2.Nome}, nascido em {cliente2.Nascimento:d}, {cliente2.Profissao}. \nNumero {conta2.Numero}, \nAgencia {conta2.Agencia}, \nSaldo R$ {conta2.Saldo}");


do
{

    Console.WriteLine("\nO que gostaria de fazer?\nSaque - 0\nDepósito - 1\nTransferência - 2");
    int i = int.Parse(Console.ReadLine());

    if (i == 0)
    {
        Console.WriteLine("Digite o valor do saque desejado: ");
        decimal s = decimal.Parse(Console.ReadLine());
        conta1.Sacar(s);
    }
    if (i == 1)
    {
        Console.WriteLine("Digite o valor para depósito: ");
        decimal d = decimal.Parse(Console.ReadLine());
        conta1.Depositar(d);
    }
    if (i == 2)
    {
        Console.WriteLine("Selecione a conta de saída: \nConta 1 - 1 \nConta2 - 2");
        if(Console.ReadLine() == "1")
        {
            Console.WriteLine("Digite o valor que deseja transferir: ");
            decimal v = decimal.Parse(Console.ReadLine());
            conta1.Transferir(conta2, v);
        }
        else
        {
            Console.WriteLine("Digite o valor que deseja transferir: ");
            decimal v = decimal.Parse(Console.ReadLine());
            conta2.Transferir(conta1, v);
        }

    }

    Console.Write($"Conta {conta1.Cliente.Nome}");
    conta1.ExibeSaldo();

    Console.Write($"Conta {conta2.Cliente.Nome}");
    conta2.ExibeSaldo();

    Console.WriteLine("\nDeseja realizar outra operação? \nSim - 0 \nNão - 1");
    n = int.Parse(Console.ReadLine());
} while (n != 1);

