int[] numeros = new int[10];

Console.WriteLine("Informe os 10 números:");
for (int i = 0; i < 10; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int contPositivos = 0;
int contNegativos = 0;
int contZeros = 0;
int somaPositivos = 0;
int somaNegativos = 0;

for (int i = 0; i < 10; i++)
{
    if (numeros[i] > 0)
    {
        contPositivos = contPositivos + 1;
        somaPositivos = somaPositivos + numeros[i];
    }
    else if (numeros[i] < 0)
    {
        contNegativos = contNegativos + 1;
        somaNegativos = somaNegativos + numeros[i];
    }
    else
    {
        contZeros = contZeros + 1;
    }
}

Console.WriteLine("Quantidade de positivos: " + contPositivos);
Console.WriteLine("Quantidade de negativos: " + contNegativos);
Console.WriteLine("Quantidade de zeros: " + contZeros);
Console.WriteLine("Soma dos positivos: " + somaPositivos);
Console.WriteLine("Soma dos negativos: " + somaNegativos);