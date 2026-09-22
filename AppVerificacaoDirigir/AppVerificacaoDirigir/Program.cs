int idade;
string resultado;

Console.WriteLine("Informe sua idade para saber se você pode ou não tirar a CNH");
idade = Convert.ToInt32(Console.ReadLine());

//Operador Ternario
resultado = (idade >= 18) ? "Essa pessoa pode tirar a CNH" : "Essa pessoa não pode tirar a CNH";

//if (idade >= 18)
//{
//    resultado = "Essa pessoa pode tirar a CNH";
//}
//else
//{
//    resultado = "Essa pessoa não pode tirar a CNH"
//}

Console.WriteLine(resultado);