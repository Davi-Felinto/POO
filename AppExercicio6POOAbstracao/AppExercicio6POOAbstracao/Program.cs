using AppExercicio6POOAbstracao.Model;

Funcionario funcionario = new Funcionario();

Console.WriteLine("Digite o nome do funcionario: ");
funcionario.nome = Console.ReadLine();

Console.WriteLine("Digite a idade do funcionario: ");
funcionario.idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o sexo do funcionario: ");
funcionario.sexo = Console.ReadLine();

Console.WriteLine("Digite o salario do funcionario: ");
funcionario.salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do funcionario");
Console.WriteLine($"Nome: {funcionario.nome}\r\n" +
                  $"Idade: {funcionario.idade}\r\n" +
                  $"Sexo: {funcionario.sexo}\r\n" +
                  $"Salario: {funcionario.salario}");

double decimoTerceiro;
int mesesTrabalhados;
Console.WriteLine("Informe a quanatidade de meses trabalhados");
mesesTrabalhados = Convert.ToInt32(Console.ReadLine());
decimoTerceiro = funcionario.CalcularDecimoTerceiro(mesesTrabalhados);
Console.WriteLine();
Console.WriteLine("Dados do Decimo Terceiro Salario");
Console.WriteLine($"O valor do decimo terceiro: {Math.Round(decimoTerceiro,2)}");
Console.WriteLine();
Console.WriteLine("Dados das Ferias");
funcionario.CalcularFerias();