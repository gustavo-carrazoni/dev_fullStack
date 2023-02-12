
int sair = 1;
double numero;
double numero2;

while (sair != 0)
{
    Console.WriteLine("\n Digite o primeiro valor:");
    numero = double.Parse(Console.ReadLine());

    Console.WriteLine("\n Digite o segundo valor:");
    numero2 = double.Parse(Console.ReadLine());

    Console.Write("\n Resultado: ");
    Console.WriteLine(numero + numero2);

    Console.WriteLine("\n Para sair, digite 0.");
    sair = int.Parse(Console.ReadLine());
}

/*
// Importação de Bibliotecas

// Nome da classe

// Declaração de método

// Declaração de variáveis
int opcao, numero1, numero2;
float resultado;

// Entradas
Console.Write("Escolha uma operação: \n\n" +
    "1 - Soma \n2 - Subtração \n3 - Divisão\n4 - Multiplicação \n\n" +
    "Digite a opção escolhida ou insira 0 para sair: \n");
opcao = int.Parse(Console.ReadLine());

// Processamento
 switch(opcao)
{
    case 1:
        Console.WriteLine("Somar\n");
        Console.Write("Digite o primeiro valor: \n");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: \n");
        numero2 = int.Parse(Console.ReadLine());

        resultado = numero1 + numero2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case 2:
        Console.WriteLine("Subtrair");
        Console.Write("Digite o primeiro valor: \n");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: \n");
        numero2 = int.Parse(Console.ReadLine());

        resultado = numero1 - numero2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case 3:
        Console.WriteLine("Dividir");
        Console.Write("Digite o primeiro valor: \n");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: \n");
        numero2 = int.Parse(Console.ReadLine());

        resultado = numero1 / numero2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case 4:
        Console.WriteLine("Multiplicar");
        Console.Write("Digite o primeiro valor: \n");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: \n");
        numero2 = int.Parse(Console.ReadLine());

        resultado = numero1 * numero2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case 0:
        Console.WriteLine("Fechando o sistema. \nBons estudos!");
        break;

}

// Saídas

*/