double valor, soma;
soma = 0;

Console.Write("Informe um valor para acumular a soma ou digite 0 para sair!");
valor = Convert.ToDouble (Console.ReadLine());

while (valor != 0)
{
    Console.WriteLine($"A soma do valor digitado {valor} + {soma} com o valor acumulado é {soma + valor}");
    soma = valor + soma;
    Console.Write("Informe um valor para acumular a soma ou digite 0 para sair!");
    valor = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"A soma dos valores acumulados foi de {soma}");