using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioRevisaoLogica.Controllers
{
    public class CalssificaoFaixaEtariaController : Controller
    {
        [HttpGet("CalssificaoFaixaEtaria")]
        public string CalssificaoFaixaEtaria(int idadePessoa)
        {
            // Declaracao de variaveis

            int idade;
            string classificacaoFaixaEtaria = "", situacaoVoto = "";

            //Entrada de dados

            idade = idadePessoa;

            //processamento

            if ((idade > 0) && (idade <= 12))
            {
                classificacaoFaixaEtaria = "Criança";
                situacaoVoto = "Não pode votar";

            }
            else if ((idade > 12) && (idade <= 17))
            {
                if ((idade >= 16) && (idade <= 17))
                {
                    classificacaoFaixaEtaria = "Adolescente";
                    situacaoVoto = "Voto opicional";
                }
                else
                {
                    classificacaoFaixaEtaria = "Adolescente";
                    situacaoVoto = "Não pode votar";
                }
            }
            else if ((idade >= 17) && (idade <= 59))
            {
                classificacaoFaixaEtaria = "Adulto";
                situacaoVoto = "Voto obrigatorio";
            }
            else
            {
                classificacaoFaixaEtaria = "Idoso";
                situacaoVoto = "Voto opicional";
            }

            // Console.WriteLine($" {classificacaoFaixaEtaria} e {situacaoVoto}");
            return $"Classificação Faixa Etaria {classificacaoFaixaEtaria}\r\nSituação Voto {situacaoVoto}";
        }
    }
}
