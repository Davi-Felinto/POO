using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioRevisaoLogica.Controllers
{
    public class CalculoBonificacaoSalarioController : Controller
    {

        [HttpPost("CalcularBonificacaoSalario")]
        public string CalcularBonificacaoSalario(double salarioFuncionario, int tempoEmpresaFuncionario)
        {
            // DECLARAÇÃO DE VARIÁVEIS
            double salario, bonificacaoSalario, percentualBonificacao;
            int tempoEmpresa;
            //ENTRADA
            salario = salarioFuncionario;
            tempoEmpresa = tempoEmpresaFuncionario;
            //PROCESSAMENTO
            if (salario < 2000)
            {
                bonificacaoSalario = salario * 0.20;
                percentualBonificacao = 20;
            }
            else if (salario >= 2000 && salario <= 5000)
            {
                bonificacaoSalario = salario * 0.10;
                percentualBonificacao = 10;
            }
            else
            {
                bonificacaoSalario = salario * 0.05;
                percentualBonificacao = 5;
            }
            if (tempoEmpresa > 10)
            {
                bonificacaoSalario += salario * 0.05;
                percentualBonificacao += 5;
            }


            return $"Percentual de bonificação: {percentualBonificacao}\r\n" +
                $"Valor da bonificação: {bonificacaoSalario}\r\n" +
                $"Salario final: {salario+bonificacaoSalario}";
        }
    }
}
