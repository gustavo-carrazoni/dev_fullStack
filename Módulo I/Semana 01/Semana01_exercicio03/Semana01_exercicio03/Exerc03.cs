
List<int> numeros = new();
List<int> numerosPares = new();
List<int> numerosImpares = new();
int somaP = 0;
int somaI = 0;

Console.WriteLine("Escreva 10 valores inteiros:");

for (int i = 0; i < 10; i++)
{
    numeros.Add(int.Parse(Console.ReadLine()));
}

numeros.Sort();

foreach (int i in numeros)
{

    if (i % 2 == 0)
    {
        numerosPares.Add(i);
    }
    else
    {
        numerosImpares.Add(i);
    }
}

Console.WriteLine("\nVocê digitou os seguintes números:");

Console.Write("Pares: ");
for (int i = 0; i < numerosPares.Count; i++)
{
    if (i < (numerosPares.Count - 1))
    {
        Console.Write(numerosPares[i] + ", ");
    }
    else
    {
        Console.Write(numerosPares[i] + ".");
    }
}

Console.Write("\nÍmpares: ");
for (int i = 0; i < numerosImpares.Count; i++)
{
    if (i < (numerosImpares.Count - 1))
    {
        Console.Write(numerosImpares[i] + ", ");
    }
    else
    {
        Console.Write(numerosImpares[i] + ".");
    }
}

for(int i = 0; i < numerosPares.Count; i++)
{
    somaP = somaP + numerosPares[i];
}
Console.WriteLine("\n\nA lista de números pares possui " + numerosPares.Count + " números, e a soma deles é igual a " + somaP);

for (int i = 0; i < numerosImpares.Count; i++)
{
    somaI = somaI + numerosImpares[i];
}
Console.WriteLine("\nA lista de números pares possui " + numerosImpares.Count + " números, e a soma deles é igual a " + somaI);

