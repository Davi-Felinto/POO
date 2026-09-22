int notaAluno;
string resultado;

Console.WriteLine("Digite a nota do aluno: ");
notaAluno = Convert.ToInt32(Console.ReadLine());

resultado = (notaAluno >= 7) ? "Aluno Aprovado" 
            : ((notaAluno <= 5) && (notaAluno > 7)) ? 
            "Aluno em Recuperação" : "Aluno Reprovado";

Console.WriteLine(resultado);
Console.ReadKey();