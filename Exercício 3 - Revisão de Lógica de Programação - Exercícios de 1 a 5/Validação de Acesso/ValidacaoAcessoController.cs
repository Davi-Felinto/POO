using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioRevisaoLogica.Controllers
{
    public class ValidacaoAcessoController : Controller
    {
        [HttpPost("ValidacaoAcesso")]
        public string ValidacaoAcesso(int idadePessoa, string senhaPessoa, string situacao)
        {
            int idade;
            string senha, situacaoConta, acessoConta;
            idade = idadePessoa;
            senha = senhaPessoa;
            situacaoConta = situacao.ToUpper();

            if ((idade >= 18) && (senha == "1234") && (situacaoConta == "SIM"))
            {
                acessoConta = "ACESSO PERMITIDO";
            }
            else
            {
                acessoConta = "ACESSO NEGADO";
            }
            Console.WriteLine(acessoConta);

            return acessoConta;
        }
    }
}
