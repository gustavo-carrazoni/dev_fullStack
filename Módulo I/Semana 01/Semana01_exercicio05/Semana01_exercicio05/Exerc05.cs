int qtd;
int c = 0;
int d = 0;

Console.WriteLine("Quantos números você gostaria de mostrar? ");
qtd = int.Parse(Console.ReadLine());
int[] num = new int[qtd];
num[0] = 1;

for(int i = 0; i < qtd;i++)
{
    if(i == 0)
    {
        Console.WriteLine(num[i]);
        num[i+1] = 1 + num[i];
    }
    if(i > 0 && i < qtd-1)
    {
        Console.WriteLine(num[i]);
        num[i+1] = num[i-1] + num[i];
    }
    if(i == qtd-1)
    {
        Console.WriteLine(num[i]);
    }
} 