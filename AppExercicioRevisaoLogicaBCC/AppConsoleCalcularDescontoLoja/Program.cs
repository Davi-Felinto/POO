// DECLARAÇÃO DE VARIÁVEIS
double valorCompra, desconto, valorFinal;
string clienteCadastro;
//ENTRADA
Console.Write("Digite o valor da compra: ");
valorCompra = Convert.ToDouble(Console.ReadLine());
valorFinal = valorCompra;
Console.Write("O cliente tem cadastro? ");
clienteCadastro = Convert.ToString(Console.ReadLine().ToUpper());
//PROCESSAMENTO
if (valorCompra > 1000)
{
    desconto = 0.15;
}
else if (valorCompra >= 500 && valorCompra <= 1000)
{
    desconto = 0.10;
}
else
{
    desconto = 0.05;
}
if (clienteCadastro == "SIM")
{
    desconto += 0.05;
}
valorFinal -= valorCompra * desconto;

Console.WriteLine($"Percentual de desconto: {desconto * 100}%\r\n" +
       $"Valor do desconto: R${valorCompra * desconto}\r\n" +
       $"Valor final: R${valorFinal}");