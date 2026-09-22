//Declaracao de variaveis
double nota1, nota2, mediaNota;
int falta;
string situacaoAluno = "";
//Entrada de dados
Console.WriteLine("Informe a 1º do aluno: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a 2º do aluno: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o numero de faltas do aluno: ");
falta = Convert.ToInt32(Console.ReadLine());

//PROCESSAMENTO DE DADOS
mediaNota = (nota1 + nota2) / 2;

if ((mediaNota >= 7) && (falta <= 10))
{
    situacaoAluno = "Aprovado";

}
else if ((mediaNota < 7) && (falta > 10))
{
    situacaoAluno = "Reprovado";

}
else if ((falta > 10))
{
    situacaoAluno = "ALUNO REPROVADO POR FALTAS";
}

//SAIDA

Console.WriteLine($"a media do aluno é: {mediaNota}");
Console.WriteLine($"situacao {situacaoAluno}");
