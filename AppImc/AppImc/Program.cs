double peso, altura, imc;
string classificacaoImc;

Console.WriteLine("Informe seu peso (em kg): ");
peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe sua altura (em metros): ");
altura = Convert.ToDouble(Console.ReadLine());

imc = Math.Round(peso / Math.Pow(altura, 2),2);
if (imc < 18.5)
{
    classificacaoImc = "Pessoa abaixo do peso";

}else if((imc >= 18.5) && (imc <= 24.9))
{
    classificacaoImc = "Pessoa com peso normal";
}else if((imc > 24.9) && (imc <= 29.9))
{
    classificacaoImc = "Pessoa com sobrepeso";
}
else
{
    classificacaoImc = "Pessoa com obesa";
}

Console.WriteLine("Classificação do IMC");
Console.WriteLine($"IMC = {imc}");
Console.WriteLine($"Classificação IMC = {classificacaoImc}");
Console.ReadKey();