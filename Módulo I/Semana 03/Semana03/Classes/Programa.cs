using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Classes
{
    public class Programa
    {
        public Produto Main()
        {
            Console.WriteLine("Inserir item vazio - 1 \nInserir dados - 2");
            int i = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                Produto produto = new Produto();
                return produto;
            }
            else
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("\nDigite o preco do produto: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("\nDigite a quantidade em estoque: ");
                int quant = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nome, preco, quant);
                return produto;
            }
        }
    }
}
