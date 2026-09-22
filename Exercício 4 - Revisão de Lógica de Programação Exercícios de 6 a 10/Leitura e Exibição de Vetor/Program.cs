int[] numero = new int[10];
for (int i = 0; i < numero.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numero[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("os números digitados são: ");
for (int i = 0; i < numero.Length; i++)
{
    Console.Write($"{numero[i]}, ");
}
Console.WriteLine($"os números digitados na ordem inversa são: {numero[i]}");
for (int i = numero.Length; i >= 0 ; i--)
{
    Console.WriteLine($"os números digitados na ordem inversa são: {numero[i]}");
}