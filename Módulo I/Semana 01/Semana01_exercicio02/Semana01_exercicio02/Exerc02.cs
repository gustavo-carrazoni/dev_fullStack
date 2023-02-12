List<string> frutas = new List<string> { };
int limiteLista = 15;
string sair = "S";

Console.WriteLine("Bem-vindo a sua lista de compras! \nPor favor, digite até " + limiteLista + " frutas para lembrá-lo de comprar no mercado: ");

for (int i = 0; i < limiteLista; i++)
{
    Console.Write("\nQual a " + (i + 1) + "ª fruta? ");
    frutas.Add(Console.ReadLine());

    if (i < (limiteLista - 1))
    {
        Console.Write("\nDeseja incluir mais alguma fruta na lista? S ou N: ");
        sair = Console.ReadLine();
    }

    if (sair.ToUpper() == "N" || sair.ToUpper() == "NÃO" || sair.ToUpper() == "NAO")
    {
        i = limiteLista - 1;
    }
}

frutas.Sort();
Console.WriteLine("\n\nLista de Frutas:");
foreach (string s in frutas)
{
    Console.WriteLine(s);
}