double raio, areaCircunferencia;
Console.WriteLine("Informe o valor da circunferência: ");
raio = Convert.ToDouble(Console.ReadLine());
//areaCircunferencia = 3.1416 * raio * raio;
areaCircunferencia = Math.Round(Math.PI * Math.Pow(raio, 2), 2);
Console.WriteLine($"A area da circunferência é: {areaCircunferencia}.");
Console.ReadKey();