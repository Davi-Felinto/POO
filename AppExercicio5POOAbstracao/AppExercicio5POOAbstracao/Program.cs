using AppExercicio5POOAbstracao.Model;

Cliente cliente = new Cliente();

Console.WriteLine("Informe o nome do Cliente: ");
cliente.nome = Console.ReadLine();

Console.WriteLine("Informe o CPF do Cliente: ");
cliente.cpf = Console.ReadLine();

Console.WriteLine("Informe a CNH do Cliente: ");
cliente.cnh = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Dados do Cliente");
Console.WriteLine($"CPF: {cliente.cpf}\r\n" +
                  $"CNH: {cliente.cnh}\r\n" +
                  $"Nome: {cliente.nome}");

Carro carro = new Carro();

Console.WriteLine("Informe a Placa do carro");
carro.placa = Console.ReadLine();

Console.WriteLine("Informe o idDcarro do carro");
carro.idCarro = Console.ReadLine();

Console.WriteLine("Informe o ano do carro");
carro.ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o fabricante do carro");
carro.fabricante = Console.ReadLine();

Console.WriteLine("Informe o modelo do carro");
carro.modelo = Console.ReadLine();

Console.WriteLine("Informe o valor da diaria do carro");
carro.valorDiaria = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do carro");
Console.WriteLine($"Placa: {carro.placa}\r\n" +
                  $"IdCarro:{carro.idCarro}\r\n" +
                  $"Fabricante: {carro.fabricante}\r\n" +
                  $"Ano: {carro.ano}\r\n" +
                  $"Cor: {carro.cor}\r\n" +
                  $"Valor Diaria: {carro.valorDiaria}");