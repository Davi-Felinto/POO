int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe {i + 1}º numero de /{numeros.Length}");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i= 0; i < numeros.Length; i++)
{
    Console.WriteLine($"vetor[{i}] = {numeros[i]}");
}