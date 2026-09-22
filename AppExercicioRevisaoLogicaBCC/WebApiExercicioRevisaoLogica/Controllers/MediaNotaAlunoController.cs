using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioRevisaoLogica.Controllers
{
    public class MediaNotaAlunoController : Controller
    {
        [HttpPost("MediaNotaAlunos")]
        public string MediaNotaAlunos(double nota1Aluno,
                              double nota2Aluno,
                              int faltaAluno)
        {

            //Declaração de Variáveis
            double nota1, nota2, mediaNota;
            int falta;
            string situacaoAluno = "", resultado = "";

            //ENTRADA
            nota1 = nota1Aluno;
            nota2 = nota2Aluno;
            falta = faltaAluno;

            //PROCESSAMENTO
            mediaNota = (nota1 + nota2) / 2;
            if ((mediaNota >= 7) && (falta <= 10))
            {
                situacaoAluno = "ALUNO APROVADO";
            }
            else if ((mediaNota < 7) && (falta <= 10))
            {
                situacaoAluno = "ALUNO REPROVADO";
            }
            else if ((falta > 10))
            {
                situacaoAluno = "ALUNO REPROVADO POR FALTAS";
            }

            //saida
            resultado = ($"A média do aluno é {mediaNota}\r\nSituação {situacaoAluno}");
            return resultado;
        }
    }
}