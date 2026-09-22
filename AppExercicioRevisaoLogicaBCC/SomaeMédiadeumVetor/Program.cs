double[] numeros = new double[10];

Console.WriteLine("Informe os 10 números:");
for (int i = 0; i < 10; i++)
{
    numeros[i] = Convert.ToDouble(Console.ReadLine());
}

double soma = 0;
double maior = numeros[0];
double menor = numeros[0];

for (int i = 0; i < 10; i++)
{
    soma = soma + numeros[i];

    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }

    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

double media = Math.Round(soma / 10, 2);

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Média: " + media);
Console.WriteLine("Maior: " + maior);
Console.WriteLine("Menor: " + menor);