int[] numeros = new int[10];

Console.WriteLine("Informe os 10 números do vetor:");
for (int i = 0; i < 10; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Número para pesquisar: ");
int alvo = Convert.ToInt32(Console.ReadLine());

int ocorrencias = 0;
string posicoes = "";

for (int i = 0; i < 10; i++)
{
    if (numeros[i] == alvo)
    {
        ocorrencias = ocorrencias + 1;

        if (posicoes == "")
        {
            posicoes = i.ToString();
        }
        else
        {
            posicoes = posicoes + ", " + i;
        }
    }
}

if (ocorrencias > 0)
{
    Console.WriteLine("Número encontrado.");
    Console.WriteLine("Quantidade de ocorrências: " + ocorrencias);
    Console.WriteLine("Posições: " + posicoes);
}
else
{
    Console.WriteLine("Número não encontrado.");
}