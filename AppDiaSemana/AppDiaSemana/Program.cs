int numeroDia;
string diaSemana = "";

Console.WriteLine("informe um dia entre 1 e 7 para saber o dia da semana");
numeroDia = Convert.ToInt32(Console.ReadLine());

switch (numeroDia)
{
    case 1:
        diaSemana = "Esse numero corresponde ao Domingo";
        break;
    case 2:
        diaSemana = "Esse numero corresponde a Segunda-feira";
        break;
    case 3:
        diaSemana = "Esse numero corresponde a Terça-feira";
        break;
    case 4:
        diaSemana = "Esse numero corresponde a Quarta-feira";
        break;
    case 5:
        diaSemana = "Esse numero corresponde a Quinta-feira";
        break;
    case 6:
        diaSemana = "Esse numero corresponde a Sexta-feira";
        break;
    case 7:
        diaSemana = "Esse numero corresponde a Sabado";
        break;
    default:
        Console.WriteLine("informe um dia da semana entre 1 e 7");
        break;
}
Console.WriteLine(diaSemana);