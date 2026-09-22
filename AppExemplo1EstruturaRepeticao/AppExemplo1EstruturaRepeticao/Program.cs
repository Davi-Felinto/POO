int contador;

Console.WriteLine("Informe um numero de 1 a 100");
contador = Convert.ToInt32(Console.ReadLine());

while (contador <= 100)
{
    Console.WriteLine($"Multiplos de 2 do contador: {contador} * 2 = {contador * 2}");
    contador = contador + 1;
}