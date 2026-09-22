int idade;
string senha, situacaoConta, acessoConta;
Console.Write("Qual a idade?");
idade = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual a senha? ");
senha = Convert.ToString(Console.ReadLine());
Console.Write("Qual a situação da conta? ");
situacaoConta = Convert.ToString(Console.ReadLine().ToUpper());

if ((idade >= 18) && (senha == "1234") && (situacaoConta == "SIM"))
{
    acessoConta = "ACESSO PERMITIDO";
}
else
{
    acessoConta = "ACESSO NEGADO";
}
Console.WriteLine(acessoConta);

Console.WriteLine(acessoConta);