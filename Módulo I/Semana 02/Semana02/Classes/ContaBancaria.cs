using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.Classes
{
    public class ContaBancaria
    {
        private int numero;
        private int agencia;
        private string titular;
        private float saldo = 0;
        private TipoConta tipo;

        public ContaBancaria(int numero, int agencia, string titular, TipoConta tipo)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.titular = titular;
            this.tipo = tipo;
        }

        public ContaBancaria(string nome, TipoConta tipo)
        {
            this.titular = nome;
            this.tipo = tipo;
            Random n = new Random();
            this.numero = n.Next(0000, 10000);
            this.agencia = n.Next(0000, 10000);
        }

        public enum TipoConta
        {
            CORRENTE = 0,
            POUPANCA = 1
        }

        internal void AcessoConta()
        {
            Console.WriteLine($"Acessando a conta: Agência {agencia} - Número {numero}.");
            Console.WriteLine($"Titular: {titular} - Tipo: {tipo}");
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor para depósito deve ser maior que 0!");
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        public void Sacar(float valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor sacado deve ser maior que 0!");
            }
            if(valor > saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo disponível em conta!");
            }
            if(valor > 0 && valor <= saldo)
            {
                saldo = saldo - valor;
                Console.WriteLine("Saque realizado!");
            }
        }

        public void ExibeSaldo()
        {
            Console.WriteLine($"\nSeu saldo atual é R$ {saldo} .");
        }
    }
}
