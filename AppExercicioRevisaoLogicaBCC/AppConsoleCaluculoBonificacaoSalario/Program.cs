// DECLARAÇÃO DE VARIÁVEIS
double salario, bonificacaoSalario, percentualBonificacao;
int tempoEmpresa;
//ENTRADA
Console.Write("Qual o salrio do funcionario? ");
salario = Convert.ToDouble(Console.ReadLine());
Console.Write("Tempo de empresa: ");
tempoEmpresa = Convert.ToInt32(Console.ReadLine());
//PROCESSAMENTO
if (salario < 2000)
{
    bonificacaoSalario = salario * 0.20;
    percentualBonificacao = 20;
}
else if (salario >= 2000 && salario <= 5000)
{
    bonificacaoSalario = salario * 0.10;
    percentualBonificacao = 10;
}
else
{
    bonificacaoSalario = salario * 0.05;
    percentualBonificacao = 5;
}
if (tempoEmpresa > 10)
{
    bonificacaoSalario += salario * 0.05;
    percentualBonificacao += 5;
}


Console.WriteLine($"Percentual de bonificação: {percentualBonificacao}\r\n" +
    $"Valor da bonificação: {bonificacaoSalario}\r\n" +
    $"Salario final: {salario + bonificacaoSalario}");