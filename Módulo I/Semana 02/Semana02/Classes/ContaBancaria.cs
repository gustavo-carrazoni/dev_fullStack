using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.Classes
{
    public class ContaBancaria
    {
        private int _numero;
        private int _agencia;
        private string _titular;
        private float _saldo = 0;
        private TipoConta _tipo;

        public ContaBancaria(int numero, int agencia, string titular, TipoConta tipo)
        {
            _numero = numero;
            _agencia = agencia;
            _titular = titular;
            _tipo = tipo;
        }

        public ContaBancaria(string nome, TipoConta tipo)
        {
            _titular = nome;
            _tipo = tipo;
            Random n = new Random();
            _numero = n.Next(0000, 10000);
            _agencia = n.Next(0000, 10000);
        }

        public enum TipoConta
        {
            CORRENTE = 0,
            POUPANCA = 1
        }

        internal void AcessoConta()
        {
            Console.WriteLine($"Acessando a conta: Agência {_agencia} - Número {_numero}.");
            Console.WriteLine($"Titular: {_titular} - Tipo: {_tipo}");
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor para depósito deve ser maior que 0!");
            }
            else
            {
                _saldo += valor;
            }
        }

        public void Sacar(float valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor sacado deve ser maior que 0!");
            }
            if(valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo disponível em conta!");
            }
            if(valor > 0 && valor <= _saldo)
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado!");
            }
        }

        public void Transferir(ContaBancaria conta, float valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor para transferência precisa ser maior que zero!");
            }
            if(valor > _saldo)
            { 
                Console.WriteLine("O valor para transferência deve ser menor ou igual ao seu saldo atual");
            }
            else
            {
                _saldo -= valor;
                conta._saldo += valor;
            }
        }

        public void ExibeSaldo()
        {
            Console.WriteLine($"\nSaldo atual é R$ {_saldo} .");
        }
    }
}
