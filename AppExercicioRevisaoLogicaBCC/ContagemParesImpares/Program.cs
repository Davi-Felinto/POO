int[] numeros = new int[10];

Console.WriteLine("Informe os 10 números:");
for (int i = 0; i < 10; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int contPares = 0;
int contImpares = 0;
int somaPares = 0;
int somaImpares = 0;

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        contPares = contPares + 1;
        somaPares = somaPares + numeros[i];
    }
    else
    {
        contImpares = contImpares + 1;
        somaImpares = somaImpares + numeros[i];
    }
}

Console.WriteLine("Quantidade de pares: " + contPares);
Console.WriteLine("Quantidade de ímpares: " + contImpares);
Console.WriteLine("Soma dos pares: " + somaPares);
Console.WriteLine("Soma dos ímpares: " + somaImpares);