using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioRevisaoLogica.Controllers
{
    public class DescontoLojaController : Controller
    {

        [HttpPost("CalcularDescontoLoja")]
        public string CalcularDescontoLoja(double valorLojaCliente, string cadastroCliente)
        {
            // DECLARAÇÃO DE VARIÁVEIS
            double valorCompra, desconto, valorFinal;
            string clienteCadastro;
            //ENTRADA
            valorCompra = valorLojaCliente;
            valorFinal = valorCompra;
            clienteCadastro = (cadastroCliente.ToUpper());
            //PROCESSAMENTO
            if (valorCompra > 1000)
            {
                desconto = 0.15;
            }
            else if (valorCompra >= 500 && valorCompra <= 1000)
            {
                desconto = 0.10;
            }
            else
            {
                desconto = 0.05;
            }
            if (clienteCadastro == "SIM")
            {
                desconto += 0.05;
            }
            valorFinal -= valorCompra * desconto;

            return $"Percentual de desconto: {desconto*100}%\r\n" +
                   $"Valor do desconto: R${valorCompra * desconto}\r\n" +
                   $"Valor final: R${valorFinal}";
        }
    }
}
