double nota, soma, mediaAluno;
soma = 0;
mediaAluno = 0;

for (int contador = 1; contador <= 3; contador++)
{
    Console.WriteLine($"informe a {contador}º nota do aluno: ");
    nota = Convert.ToDouble(Console.ReadLine());
    soma = nota + soma;
    mediaAluno = soma / contador;
}
Console.WriteLine($"A media as notas informas é: {mediaAluno}");
