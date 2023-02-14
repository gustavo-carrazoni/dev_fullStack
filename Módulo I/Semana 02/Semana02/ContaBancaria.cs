using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string titular;
        public float saldo = 0;
        public enum TipoConta
        {
            CORRENTE = 0,
            POUPANCA = 1
        }
    }
}
