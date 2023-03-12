
using Semana03.Classes;

Programa executar = new Programa();

int i = 1;
int c = 0;
Produto[] produtos = new Produto[2];

while(i == 1)
{
    produtos[c] = executar.Main();

    Console.WriteLine("Inserir outro produto - 1");
    i = int.Parse(Console.ReadLine());
    c++;
}

Console.WriteLine("Os produtos em estoque são: \n\n" +
    "Nome  -  Quantidade  -  Preço");
for (int n = 0; n < 2; n++)
{
    Console.WriteLine($"{produtos[n].nome} - {produtos[n].quant} - {produtos[n].preco}\n");

}

