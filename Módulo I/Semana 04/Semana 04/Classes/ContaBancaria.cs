namespace Semana_04.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            Saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor para depósito deve ser maior que 0!");
            }
            else
            {
                Saldo = Saldo + valor;
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor sacado deve ser maior que 0!");
            }
            if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo disponível em conta!");
            }
            if (valor > 0 && valor <= Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque realizado!");
            }
        }

        public void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor para transferência precisa ser maior que zero!");
            }
            if (valor > Saldo)
            {
                Console.WriteLine("O valor para transferência deve ser menor ou igual ao seu saldo atual");
            }
            else
            {
                Saldo -= valor;
                conta.Saldo = conta.Saldo + valor;
            }
        }

        public void ExibeSaldo()
        {
            Console.WriteLine($"\nSaldo atual é R$ {Saldo} .");
        }

    }

}