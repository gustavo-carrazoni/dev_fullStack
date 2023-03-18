using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04.Classes
{
    public class Empresarial: ContaBancaria
    {
        public Empresarial(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != Enum.TipoPessoa.JURIDICA)
            {
                Console.WriteLine("Cliente deve ser pessoa jurídica!");

            }
            else
            {
                Console.WriteLine($"Conta empresarial criada para {cliente.Nome}.");
            }

        }
    }
}
