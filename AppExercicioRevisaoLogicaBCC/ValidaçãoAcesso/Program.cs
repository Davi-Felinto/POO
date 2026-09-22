int idade;
string senha, situacaoConta, acessoConta;
Console.WriteLine("Informe a idade do usuário");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a senha do usuário");
senha = Console.ReadLine();

Console.WriteLine("Informe se o usuário está ativo (SIM/NÃO)");
situacaoConta = Console.ReadLine().ToUpper();

if ((idade >= 18) && (senha == "Senh@240826!") && (situacaoConta == "SIM"))
{
    acessoConta = "ACESSO PERMITIDO";
}
else
{
    acessoConta = "ACESSO NEGADO";
}
Console.WriteLine(acessoConta);