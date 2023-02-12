int qtdA;
int qtdN;

Console.WriteLine("Bem-vind@ ao verificador de médias! \nAqui você pode incluir quantos alunos quiser e calcular a média de até 5 avaliações deles! \n\nQuantos alunos você gostaria de incluir?");
qtdA = int.Parse(Console.ReadLine());
Console.WriteLine("E quantas avaliações/notas você aplicou?");
qtdN = int.Parse(Console.ReadLine());

int[,] notas = new int[qtdA,qtdN];
var alunos = new Dictionary<int, string>();
double[] media = new double[qtdA];

for (int i = 0; i < qtdA; i++)
{
    Console.Write("\nEscreva o nome do " + (i+1) + "º aluno: ");
    string n = Console.ReadLine();
    alunos.Add(i, n);

    Console.Write("\nDigite as notas deste aluno: \n");
    for (int c = 0; c < qtdN; c++)
    {
        notas[i, c] = int.Parse(Console.ReadLine());
    }
}



for(int i = 0; i < qtdN; i++)
{
    int soma = 0;
    for(int c = 0; c < qtdN; c++)
    {
        soma = soma + notas[i, c];
    }
    media[i] = Convert.ToDouble(soma) / Convert.ToDouble(qtdN);
}


for (int i = 0; i < qtdA; i++)
{
    string M = string.Format("{0:0.00}", media[i]);

    Console.Write("\nAluno: " + alunos[i] + "\nMédia: " + M + " - ");
    if (media[i] >= 6)
    {
        Console.Write("Aprovado! =)");
    }
    else
    {
        Console.Write("Reprovado ='(");
    }
}