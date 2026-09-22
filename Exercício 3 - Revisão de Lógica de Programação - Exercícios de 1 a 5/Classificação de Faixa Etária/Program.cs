// Declaracao de variaveis

int idade;
string classificacaoFaixaEtaria = "", situacaoVoto = "";

//Entrada de dados

Console.WriteLine("Informe a idade da pessoa para saber sua faixa etaria e se ela pode votar ou não: ");
idade = Convert.ToInt32(Console.ReadLine());

//processamento

if ((idade > 0) && (idade <= 12))
{
    classificacaoFaixaEtaria = "Criança";
    situacaoVoto = "Não pode votar";

}
else if ((idade > 12) && (idade <= 17))
{
    if ((idade >= 16) && (idade <= 17))
    {
        classificacaoFaixaEtaria = "Adolescente";
        situacaoVoto = "Voto opicional";
    }
    else
    {
        classificacaoFaixaEtaria = "Adolescente";
        situacaoVoto = "Não pode votar";
    }
}
else if ((idade >= 17) && (idade <= 59))
{
    classificacaoFaixaEtaria = "Adulto";
    situacaoVoto = "Voto obrigatorio";
}
else
{
    classificacaoFaixaEtaria = "Idoso";
    situacaoVoto = "Voto opicional";
}

Console.WriteLine($" {classificacaoFaixaEtaria} e {situacaoVoto}");