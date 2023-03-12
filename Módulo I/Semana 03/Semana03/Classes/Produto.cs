using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Classes
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quant;

        public Produto()
        {
            this.nome = "Sem nome";
            this.preco = 0;
            this.quant = 0;
        }

        public Produto(string nome, double preco, int quant)
        {
            this.nome = nome;
            this.preco = preco;
            this.quant = quant;
        }
    }
}
