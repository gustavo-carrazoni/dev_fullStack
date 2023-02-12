int[] numeros = new int[10];
List<int> numerosPrimos = new List<int> { };
double numeroDigitado;
string sair;
int i = 0;
int divisor;

Console.WriteLine("Seja bem-vindo ao Buscador de Números Primos! \n");
Console.WriteLine("Digite até 10 números inteiros e descubra quais são números primos.");

do
{
    Console.Write("\nDigite o " + (i + 1) + "º número: ");
    numeroDigitado = double.Parse(Console.ReadLine());

    bool verificaInteiro = numeroDigitado == (int)numeroDigitado;

    if (verificaInteiro)
    {
        numeros[i] = Convert.ToInt32(numeroDigitado);
    }
    else
    {
        Console.WriteLine("\nO número digitado não é inteiro. Por favor, digite um número inteiro.");
        i--;
    }

    if( i < 10)
    {
        Console.Write("\nDeseja digitar outro número? S ou N -> ");
        sair = Console.ReadLine();
    }
    else
    {
        sair = "N";
    }
    i++;

} while (sair.ToUpper() != "N" && i < 10);


Console.WriteLine("\nVocê digitou os seguintes números: ");
for(int c = 0; c < i; c++)
{
    if(c < (i-1))
    {
        Console.Write(numeros[c] + ", ");
    }
    else
    {
        Console.Write(numeros[c]);
    }
}

Console.Write("\nE destes, os números primos são: ");

for (int c = 0; c < i; c++)
{
    divisor = 0;
    for (int d = 0; d <= numeros[c]; d++)
    {
        if (numeros[c] % (d + 1) == 0)
        {
            divisor++;
        }
    }

    if (divisor == 2)
    {
        numerosPrimos.Add(numeros[c]);
    }
}

numerosPrimos.Sort();
foreach (int c in numerosPrimos)
{
    Console.Write(c + ", ");
}


Console.WriteLine("\n\nObrigado por usar nosso Buscador de Números Primos!\n");

