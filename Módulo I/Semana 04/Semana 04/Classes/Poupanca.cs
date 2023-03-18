using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04.Classes
{
    public class Poupanca : ContaBancaria
    {
        public Poupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != Enum.TipoPessoa.FISICA)
            {
                Console.WriteLine("Cliente deve ser pessoa física!");

            }
            else
            {
                Console.WriteLine($"Conta poupança criada para {cliente.Nome}.");
            }

        }
    }
}
