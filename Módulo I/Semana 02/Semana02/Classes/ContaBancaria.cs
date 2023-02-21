using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.Classes
{
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string titular;
        public float saldo = 0;
        public TipoConta tipo;


        public enum TipoConta
        {
            CORRENTE = 0,
            POUPANCA = 1
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
